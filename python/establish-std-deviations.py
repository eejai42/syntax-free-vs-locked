import os
import sys
import pandas as pd

# Load the CSV file
# Get the directory where the script is located
script_directory = os.path.dirname(os.path.abspath(sys.argv[0]))

# Construct the full path to the CSV file
csv_file_path = os.path.join(script_directory, "trial.csv")
df = pd.read_csv(csv_file_path)

# Define columns to analyze for standard deviation
columns_to_analyze = [
    'CountOfCharacteristics',
    'CountOfFeatures',
    'CountOfAKAs',
    'CountOfMismatches',
    'ChangeInCharacteristics',
    'ChangeInAKAs'
]

# Separate the syntax-locked and syntax-free groups
syntax_locked_df = df[df['ExpTransformerIsSyntaxFree'].str.contains("0 checked out of 1")]
syntax_free_df = df[df['ExpTransformerIsSyntaxFree'].str.contains("1 checked out of 1")]

# Function to calculate standard deviations
def calculate_std_devs(group_df, group_name):
    std_devs = {}
    print(f"Standard Deviations for {group_name}:")
    for column in columns_to_analyze:
        std_dev = group_df[column].std()
        std_devs[column] = std_dev
        print(f"{column}: {std_dev}")
    print("\n")
    return std_devs

# Calculate standard deviations for each group
syntax_locked_std_devs = calculate_std_devs(syntax_locked_df, "Syntax-Locked")
syntax_free_std_devs = calculate_std_devs(syntax_free_df, "Syntax-Free")

# Prepare the output data
output_data = {
    'Metric': columns_to_analyze,
    'Syntax-Locked Std Dev': [syntax_locked_std_devs[col] for col in columns_to_analyze],
    'Syntax-Free Std Dev': [syntax_free_std_devs[col] for col in columns_to_analyze]
}

# Create a DataFrame for the output data
output_df = pd.DataFrame(output_data)

# Save the results to a new CSV file
output_df.to_csv("std_devs_output.csv", index=False)

print("Standard deviations have been saved to 'std_devs_output.csv'.")
