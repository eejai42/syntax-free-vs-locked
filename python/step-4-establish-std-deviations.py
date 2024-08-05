import os
import sys
import openpyxl
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from scipy.stats import ttest_ind

# Load the CSV file
# Get the directory where the script is located
script_directory = os.path.dirname(os.path.abspath(sys.argv[0]))

trial = "simple"
# trial = "long_prompt"
# trial = "format_toggle"

# Construct the full path to the CSV file
csv_file_path = os.path.join(script_directory, "..", f"{trial}_trial.csv")
df = pd.read_csv(csv_file_path)

# Define columns to analyze
columns_to_analyze = [
    'CountOfAKAs',
    'ChangeInAKAs'
]

# Separate the syntax-locked and syntax-free groups
syntax_locked_df = df[df['ExpTransformerIsSyntaxFree'] == 0]
syntax_free_df = df[df['ExpTransformerIsSyntaxFree'] == 1]

# Function to calculate statistics
def calculate_statistics(group_df, group_name):
    statistics = {}
    print(f"Statistics for {group_name}:")
    for column in columns_to_analyze:
        stats = {
            'Count': group_df[column].count(),
            'Mean': group_df[column].mean(),
            'Median': group_df[column].median(),
            'Min': group_df[column].min(),
            'Max': group_df[column].max(),
            'Std Dev': group_df[column].std()
        }
        statistics[column] = stats
        print(f"{column}: {stats}")
    print("\n")
    return statistics

# Calculate statistics for each group
syntax_locked_stats = calculate_statistics(syntax_locked_df, "Syntax-Locked")
syntax_free_stats = calculate_statistics(syntax_free_df, "Syntax-Free")

# Function to calculate p-values
def calculate_p_values():
    p_values = {}
    for column in columns_to_analyze:
        _, p_value = ttest_ind(syntax_locked_df[column], syntax_free_df[column], equal_var=False)
        p_values[column] = p_value
    return p_values

# Calculate p-values for each metric
p_values = calculate_p_values()

# Prepare the output data
output_data = {
    'Metric': columns_to_analyze,
    'SLStdDev': [syntax_locked_stats[col]['Std Dev'] for col in columns_to_analyze],
    'SFStdDev': [syntax_free_stats[col]['Std Dev'] for col in columns_to_analyze],
    'PValue': [f"{p_values[col]:.6f}" for col in columns_to_analyze],
    'StdDevFactor': [syntax_locked_stats[col]['Std Dev'] / syntax_free_stats[col]['Std Dev'] if syntax_free_stats[col]['Std Dev'] != 0 else None for col in columns_to_analyze],
    'SLCount': [syntax_locked_stats[col]['Count'] for col in columns_to_analyze],
    'SLMean': [syntax_locked_stats[col]['Mean'] for col in columns_to_analyze],
    'SLMedian': [syntax_locked_stats[col]['Median'] for col in columns_to_analyze],
    'SLMin': [syntax_locked_stats[col]['Min'] for col in columns_to_analyze],
    'SLMax': [syntax_locked_stats[col]['Max'] for col in columns_to_analyze],
    'SFCount': [syntax_free_stats[col]['Count'] for col in columns_to_analyze],
    'SFMean': [syntax_free_stats[col]['Mean'] for col in columns_to_analyze],
    'SFMedian': [syntax_free_stats[col]['Median'] for col in columns_to_analyze],
    'SFMin': [syntax_free_stats[col]['Min'] for col in columns_to_analyze],
    'SFMax': [syntax_free_stats[col]['Max'] for col in columns_to_analyze],
}

# Create a DataFrame for the output data
output_df = pd.DataFrame(output_data)

# Create an Excel writer object and save the DataFrame to Excel
with pd.ExcelWriter(f"{trial}_analysis.xlsx", engine='openpyxl') as writer:
    # Write original data to the first sheet
    df.to_excel(writer, sheet_name='Original Data', index=False)
    
    # Write output data (statistics and p-values) to the second sheet
    output_df.to_excel(writer, sheet_name='Results', index=False)

    # Adjust column widths for better visibility
    worksheet1 = writer.sheets['Original Data']
    worksheet2 = writer.sheets['Results']

    # Function to set the column widths based on the maximum content width
    def set_column_widths(worksheet, dataframe):
        for i, column in enumerate(dataframe.columns):
            max_length = max(dataframe[column].astype(str).apply(len).max(), len(column)) + 2
            worksheet.column_dimensions[openpyxl.utils.get_column_letter(i+1)].width = max_length

    set_column_widths(worksheet1, df)
    set_column_widths(worksheet2, output_df)

print("Data has been saved to 'output_data.xlsx' with original data and results.")

# Function to create a box plot for each metric
# def create_box_plots():
#     for column in columns_to_analyze:
#         plt.figure(figsize=(10, 6))
#         sns.boxplot(x='ExpTransformerIsSyntaxFree', y=column, data=df, palette='Set2')
#         plt.title(f'Box Plot of {column} (0 = Syntax-Locked, 1 = Syntax-Free)')
#         plt.xticks([0, 1], ['Syntax-Locked', 'Syntax-Free'])
#         plt.xlabel('Methodology')
#         plt.ylabel(column)
#         plt.grid(True)
#         plt.savefig(f'{column}_boxplot.png')
        # plt.show()

# Function to create a distribution plot for each metric
def create_distribution_plots():
    for column in columns_to_analyze:
        plt.figure(figsize=(10, 6))
        sns.histplot(df[df['ExpTransformerIsSyntaxFree'] == 0][column], color='blue', label='Syntax-Locked', kde=True, stat="density", linewidth=0)
        sns.histplot(df[df['ExpTransformerIsSyntaxFree'] == 1][column], color='green', label='Syntax-Free', kde=True, stat="density", linewidth=0)
        plt.title(f'Distribution of {column}')
        plt.xlabel(column)
        plt.ylabel('Density')
        plt.legend()
        plt.grid(True)
        png_file_path = os.path.join(script_directory, "..", f'{trial}_{column}_distribution.png')
        plt.savefig(png_file_path)
        # plt.show()

# Function to create a bar plot comparing mean values
def create_mean_comparison_plot():
    mean_values = output_df[['Metric', 'SLMean', 'SFMean']].melt(id_vars='Metric', var_name='Methodology', value_name='Mean')
    
    plt.figure(figsize=(12, 7))
    sns.barplot(x='Metric', y='Mean', hue='Methodology', data=mean_values, palette='Set1')
    plt.title('Comparison of Mean Values')
    plt.xticks(rotation=45)
    plt.ylabel('Mean')
    plt.xlabel('Metric')
    plt.grid(True)
    png_file_path = os.path.join(script_directory, "..", 'mean_comparison.png')
    plt.savefig(png_file_path)
    # plt.show()

# Call the functions to generate the plots
# create_box_plots()
create_distribution_plots()
create_mean_comparison_plot()
