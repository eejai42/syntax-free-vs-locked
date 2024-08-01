import requests
import json
import os
import sys
import re

REST_BEARER_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImF1dGgwfDY2N2Y1YjU1OTBiOTYzZTM2NzIyNGUwOCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJlaitoYW5nbWFuMUBzc290Lm1lIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoiZWoraGFuZ21hbjFAc3NvdC5tZSIsInBpY3R1cmUiOiJodHRwczovL3MuZ3JhdmF0YXIuY29tL2F2YXRhci9kMmFiZmYzYmNhY2NmYmFlZmM0NjE2ODI1MTdlMTE3OD9zPTQ4MCZyPXBnJmQ9aHR0cHMlM0ElMkYlMkZjZG4uYXV0aDAuY29tJTJGYXZhdGFycyUyRmVqLnBuZyIsImVtYWlsX3ZlcmlmaWVkIjoiVHJ1ZSIsImV4cCI6MTcyMjU3ODY3MywiaXNzIjoiZWotdGljdGFjdG9lLWRlbW8udXMuYXV0aDAuY29tIiwiYXVkIjoiaHR0cHM6Ly9lai10aWN0YWN0b2UtZGVtby51cy5hdXRoMC5jb20vYXBpL3YyIn0.AnflVJjZmXdeGV6FGLCHFxDH2-2ALAf8uTO-1X5I_vU"
BASE_URL = "https://localhost:42016/User"
HEADERS = {
    "Authorization": f"Bearer {REST_BEARER_TOKEN}",
    "Content-Type": "application/json"
}

# Define the experiment features with variations and partial matches
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
    # Add other features with their variations and partial matches
]

def get_trial_artifacts_needing_cleaning():
    url = f"{BASE_URL}/ArtifactAnalyses?view=NeedsCleanValidationJson"
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

def clean_and_update_artifacts():
    artifacts = get_trial_artifacts_needing_cleaning()
    for artifact in artifacts:
        artifact["GenerationName"] = None
        artifact["GenerationTransformerNumber"] = None
        artifact["TransformerGeneratioNumber"] = None
        artifact["TransformerGenerationName"] = None
        artifact["GenerationName"] = None
        artifact["GenerationName"] = None
        artifact["GenerationName"] = None
        cleaned_json = clean_json(artifact['TrialArtifactValidationResponse'])
        cleaned_json_string = json.dumps(cleaned_json, indent=4)
        artifact['CleanValidationJson'] = cleaned_json_string
        update_trial_artifact(artifact)

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
    if not name:
        return None

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

def update_trial_artifact(artifact):
    url = f"{BASE_URL}/ArtifactAnalysis"
    payload = {
        "ArtifactAnalysis": artifact
    }
    response = requests.put(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

if __name__ == "__main__":
    print("Starting cleanup process...")
    clean_and_update_artifacts()
    print("Cleanup process completed successfully.")
