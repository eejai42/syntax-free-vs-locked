import os
import sys
import openpyxl
import pandas as pd
from scipy.stats import ttest_ind

# Load the CSV file
# Get the directory where the script is located
script_directory = os.path.dirname(os.path.abspath(sys.argv[0]))

# Construct the full path to the CSV file
csv_file_path = os.path.join(script_directory, "trial.csv")
df = pd.read_csv(csv_file_path)

# Define columns to analyze
columns_to_analyze = [
    'CountOfCharacteristics',
    'CountOfAKAs',
    'ChangeInCharacteristics',
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
    'Syntax-Locked Std Dev': [syntax_locked_stats[col]['Std Dev'] for col in columns_to_analyze],
    'Syntax-Free Std Dev': [syntax_free_stats[col]['Std Dev'] for col in columns_to_analyze],
    'P-Value': [f"{p_values[col]:.6f}" for col in columns_to_analyze],
    'Std Dev Factor': [syntax_locked_stats[col]['Std Dev'] / syntax_free_stats[col]['Std Dev'] if syntax_free_stats[col]['Std Dev'] != 0 else None for col in columns_to_analyze],
    'Syntax-Locked Count': [syntax_locked_stats[col]['Count'] for col in columns_to_analyze],
    'Syntax-Free Count': [syntax_free_stats[col]['Count'] for col in columns_to_analyze],
    'Syntax-Locked Mean': [syntax_locked_stats[col]['Mean'] for col in columns_to_analyze],
    'Syntax-Free Mean': [syntax_free_stats[col]['Mean'] for col in columns_to_analyze],
    'Syntax-Locked Median': [syntax_locked_stats[col]['Median'] for col in columns_to_analyze],
    'Syntax-Free Median': [syntax_free_stats[col]['Median'] for col in columns_to_analyze],
    'Syntax-Locked Min': [syntax_locked_stats[col]['Min'] for col in columns_to_analyze],
    'Syntax-Free Min': [syntax_free_stats[col]['Min'] for col in columns_to_analyze],
    'Syntax-Locked Max': [syntax_locked_stats[col]['Max'] for col in columns_to_analyze],
    'Syntax-Free Max': [syntax_free_stats[col]['Max'] for col in columns_to_analyze],
}

# Create a DataFrame for the output data
output_df = pd.DataFrame(output_data)

# Create an Excel writer object and save the DataFrame to Excel
with pd.ExcelWriter("output_data.xlsx", engine='openpyxl') as writer:
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