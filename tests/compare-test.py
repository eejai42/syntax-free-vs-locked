import json
import pandas as pd

def load_json_data(file_path):
    with open(file_path, 'r') as file:
        return json.load(file)

def normalize_signature(signature):
    # Normalize spacing and remove return types for easier comparison
    normalized = signature.split("->")[0].strip()
    func_name, params = normalized.split("(")
    params = params.replace(" ", "").rstrip(")")
    return f"{func_name.strip()}({params})"

def process_data(data):
    full_signatures = []
    function_names = set()
    for item in data:
        for sig in item['PythonFunctionSignatures']:
            # Adding full signature
            full_signatures.append(sig)
            # Adding function name only
            func_name = sig.split('(')[0].strip()
            function_names.add(func_name)
    return full_signatures, list(function_names)

def create_excel_report(locked_signatures, locked_names, free_signatures, free_names):
    with pd.ExcelWriter('function_signatures_analysis.xlsx') as writer:
        # Syntax-Locked Data
        pd.DataFrame({'Function Names': locked_names}).to_excel(writer, sheet_name='Locked Function Names', index=False)
        pd.DataFrame(pd.Series(locked_signatures).value_counts(), columns=['Count']).reset_index().rename(columns={'index': 'Full Signatures'}).to_excel(writer, sheet_name='Locked Full Signatures', index=False)
        
        # Syntax-Free Data
        pd.DataFrame({'Function Names': free_names}).to_excel(writer, sheet_name='Free Function Names', index=False)
        pd.DataFrame(pd.Series(free_signatures).value_counts(), columns=['Count']).reset_index().rename(columns={'index': 'Full Signatures'}).to_excel(writer, sheet_name='Free Full Signatures', index=False)

# Load data
locked_data = load_json_data('syntax-locked-test.json')
free_data = load_json_data('syntax-free-test.json')

# Process the data
locked_full_sigs, locked_func_names = process_data(locked_data)
free_full_sigs, free_func_names = process_data(free_data)

# Generate the Excel report
create_excel_report(locked_full_sigs, locked_func_names, free_full_sigs, free_func_names)

print("Excel file generated successfully with function signature analysis.")
