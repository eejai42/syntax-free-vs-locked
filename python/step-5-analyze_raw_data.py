import os
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from scipy import stats

def process_data(input_file):
    # Construct the full file path
    input_file = os.path.join(os.path.dirname(__file__), input_file)
    
    # Load the dataset
    data = pd.read_csv(input_file)
    
    # Output file name conversion
    output_file = input_file.replace('.csv', '.xlsx')
    
    # Open a Pandas Excel writer using XlsxWriter as the engine
    writer = pd.ExcelWriter(output_file, engine='xlsxwriter')
    
    # Statistics (formerly RawStatistics)
    raw_stats = data.groupby('CalculatedStatus')['ExtractedAccuracyScore'].agg(['count', 'min', 'max', 'mean', 'median', 'std'])
    raw_stats['p-value'] = stats.norm.sf(raw_stats['mean']/raw_stats['std']) # assuming normal distribution
    raw_stats.reset_index().to_excel(writer, sheet_name='Statistics', index=False)
    
    # BinnedData and RawData (renamed to Binned Conversations and Detailed Conversations)
    binned_data_list = []
    stats_list = []
    for status, group in data.groupby('CalculatedStatus'):
        group_data = group.groupby('ConversationIdentifier')['ExtractedAccuracyScore'].mean().reset_index()
        group_data = group_data.sort_values(by='ExtractedAccuracyScore', ascending=False)
        group_data['bin'] = group_data.index // 7
        binned_data = group_data.groupby('bin')['ExtractedAccuracyScore'].agg(['mean', 'count']).reset_index()
        binned_data = binned_data.sort_values(by='mean', ascending=False).reset_index(drop=True)
        binned_data['bin'] = range(1, len(binned_data) + 1)  # Reassigning bin numbers after sorting
        binned_data['CalculatedStatus'] = status
        binned_data_list.append(binned_data)
        
        # Binned Conversations tab
        stats_list.extend([
            {'CalculatedStatus': status, 'BinNumber': bin_number + 1, 'AccuracyScore': row['mean']}
            for bin_number, row in binned_data.iterrows()
        ])
        
    binned_data_combined = pd.concat(binned_data_list)
    binned_data_combined.to_excel(writer, sheet_name='Binned Conversations', index=False)
    
    stats_df = pd.DataFrame(stats_list)
    stats_df.to_excel(writer, sheet_name='Detailed Conversations', index=False)
    
    # RawData tab (moved to the end)
    data.to_excel(writer, sheet_name='RawData', index=False)
    
    # Save the writer and close the Excel file
    writer.close()
    
    # Plotting
    fig, ax = plt.subplots()
    styles = {
        'Syntax-FREE': {'color': 'blue', 'linestyle': '-', 'linewidth': 2},
        'Syntax-Locked': {'color': 'red', 'linestyle': ':', 'linewidth': 1},
        'FREE-Locked': {'color': 'purple', 'linestyle': '--', 'linewidth': 2}
    }
    for status in ['Syntax-FREE', 'Syntax-Locked', 'FREE-Locked']:
        subset = stats_df[stats_df['CalculatedStatus'] == status]
        ax.plot(subset['BinNumber'], subset['AccuracyScore'], label=f'{status} (n={len(subset)})', **styles[status])
    
    ax.set_title('Average Accuracy Score by Status and Bin')
    ax.set_xlabel('Bin Number (Each bin represents an average of 35 scores)')
    ax.set_ylabel('Average Accuracy Score')
    ax.legend(title='Calculated Status')
    
    # Save the plot as an image file
    plot_file = output_file.replace('.xlsx', '.png')
    plt.savefig(plot_file)
    plt.close()

# Example usage:
process_data('raw_trail_data.csv')
