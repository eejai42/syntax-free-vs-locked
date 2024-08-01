import json
import re

# Sample experiment features with variations and partial matches
experiment_features = [
    {
        "Name": "ToDoItems",
        "Variations": "to do items, items, tasks, to do tasks, to dos, to do item, item, task, to do task, to do",
        "PartialMatches": "task, do"
    },
    {
        "Name": "Categories",
        "Variations": "categories, category",
        "PartialMatches": "categ"
    },
    {
        "Name": "DueDates",
        "Variations": "due dates, due date, due on, due",
        "PartialMatches": "due"
    },
    # ... add all other features with their variations and partial matches
]

def extract_json_from_natural_language_text_with_regex(llm_json_response):
    # Extract JSON blob from natural language text
    json_match = re.search(r"\{[\s\S]*?\}", llm_json_response)
    if json_match:
        return json_match.group(0)
    return None

def extract_comma_separated_list_of_features_identified(llm_json):
    # Extract the list of features from the Features field
    try:
        data = json.loads(llm_json)
        return data.get("Features", [])
    except json.JSONDecodeError:
        return []

def extract_keywords_listed_as_raw_data(llm_json):
    # Extract the raw keyword elements
    try:
        data = json.loads(llm_json)
        return data.get("Keywords", [])
    except json.JSONDecodeError:
        return []

def normalize_feature_name(name, feature_data):
    # Normalize the feature name based on the variations and partial matches
    name_lower = name.lower()
    for feature in feature_data:
        # Generate sub-variations for each variation
        variations = feature["Variations"].split(", ")
        for base_variation in variations:
            sub_variations = generate_sub_variations(base_variation)
            if any(name_lower == sub_variation.lower() for sub_variation in sub_variations):
                return feature["Name"]
        
        # Check for partial matches
        partial_matches = feature["PartialMatches"].split(", ")
        if any(pm in name_lower for pm in partial_matches):
            return feature["Name"]
    
    return None

def generate_sub_variations(variation):
    # Generate variations with spaces, no spaces, and hyphens
    space_variation = variation.strip()
    no_space_variation = variation.replace(" ", "")
    hyphen_variation = variation.replace(" ", "-")
    return [space_variation, no_space_variation, hyphen_variation]

def extract_clean_features_feature_elements(raw_feature_elements):
    # Clean and normalize the raw feature elements
    clean_features = []
    for keyword in raw_feature_elements:
        keyword_name = keyword.get("KeywordName") or keyword.get("Keyword Name") or keyword.get("Keyword")
        is_missing = keyword.get("IsMissing")
        aka = keyword.get("AKA")
        
        normalized_name = normalize_feature_name(keyword_name, experiment_features)
        if normalized_name:
            clean_feature = {
                "KeywordName": normalized_name,
                "IsMissing": is_missing if is_missing is not None else False,
                "AKA": aka
            }
            clean_features.append(clean_feature)
    
    return clean_features

def clean_json(llm_json_response):
    # Extract JSON from natural language
    llm_json = extract_json_from_natural_language_text_with_regex(llm_json_response)
    if not llm_json:
        return {}
    
    # Extract features and raw feature elements
    feature_list = extract_comma_separated_list_of_features_identified(llm_json)
    raw_feature_elements = extract_keywords_listed_as_raw_data(llm_json)
    
    # Normalize and clean features
    clean_features = extract_clean_features_feature_elements(raw_feature_elements)
    
    # Create the clean JSON structure
    clean_json_structure = {
        "Features": feature_list,
        "Keywords": clean_features
    }
    
    return clean_json_structure

# Example usage with a sample JSON response
llm_json_response = """
Some introduction text here. Below is the JSON:
{
  "Features": ["ToDoItems", "Categories", "DueDates", "Reminders", "AssignedTo"],
  "Keywords": [
    {
      "KeywordName": "ToDoItems",
      "IsMissing": false,
      "AKA": "tasks"
    },
    {
      "KeywordName": "Categories",
      "IsMissing": false,
      "AKA": "categorization of tasks"
    },
    {
      "KeywordName": "DueDates",
      "IsMissing": false,
      "AKA": "due date feature"
    },
    {
      "KeywordName": "Priorities",
      "IsMissing": true
    },
    {
      "KeywordName": "Progress",
      "IsMissing": true
    },
    {
      "KeywordName": "Statuses",
      "IsMissing": true
    },
    {
      "KeywordName": "Reminders",
      "IsMissing": false,
      "AKA": "timely reminders"
    },
    {
      "KeywordName": "Notifications",
      "IsMissing": true
    },
    {
      "KeywordName": "Completion",
      "IsMissing": true
    },
    {
      "KeywordName": "AssignedTo",
      "IsMissing": false,
      "AKA": "assigned to attribute"
    },
    {
      "KeywordName": "Duration",
      "IsMissing": true
    },
    {
      "KeywordName": "CompletedDate",
      "IsMissing": true
    },
    {
      "KeywordName": "ToDoColors",
      "IsMissing": true
    }
  ]
}
Some concluding text here.
"""

cleaned_json = clean_json(llm_json_response)
print(json.dumps(cleaned_json, indent=2))
