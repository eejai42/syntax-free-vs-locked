import requests
import json
import os
import sys

REST_BEARER_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6Imdvb2dsZS1vYXV0aDJ8MTA1NzYwMDM4MzgyNzgzMTI0MTYxIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZSI6IkVKIEFsZXhhbmRyYSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6ImVlamFpNDJAZ21haWwuY29tIiwicGljdHVyZSI6Imh0dHBzOi8vbGgzLmdvb2dsZXVzZXJjb250ZW50LmNvbS9hL0FDZzhvY0kxbWFHeXVIUG5tSWFFbG40cVI5UXFaUFdMX3NMLVZabmVfd1ZxeUV4bXg4b2JRYWJ6bXc9czk2LWMiLCJlbWFpbF92ZXJpZmllZCI6IlRydWUiLCJleHAiOjE3MjI4MjM3MDUsImlzcyI6ImVqLXRpY3RhY3RvZS1kZW1vLnVzLmF1dGgwLmNvbSIsImF1ZCI6Imh0dHBzOi8vZWotdGljdGFjdG9lLWRlbW8udXMuYXV0aDAuY29tL2FwaS92MiJ9.blIjJCTFrXYpJvquW133qaw65H7DBzerbCLUBamizxI"
BASE_URL = "https://localhost:42016/User"
HEADERS = {
    "Authorization": f"Bearer {REST_BEARER_TOKEN}",
    "Content-Type": "application/json"
}

def get_generation_transform_by_number(transform_number):
    url = f"{BASE_URL}/GenerationTransformers?airtableWhere=AND(TransformerNumber%3D{transform_number})"
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    generator = response.json()
    if not generator:
        return None
    else:
        return generator[0]

def get_existing_artifact_without_validator(transform_number):
    url = f"{BASE_URL}/TrialArtifacts?airtableWhere=OR(AND(Trial=Blank(),TransformerNumber%3D{transform_number}%2cNOT(PrimaryExtensionArtifact))%2cArtifactIdentifier%3D{transform_number})"
    print("URL:", url)
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    artifacts = response.json()
    return artifacts

def create_trial_artifact(generation_transform_id):
    url = f"{BASE_URL}/TrialArtifact"
    payload = {
        "TrialArtifact": {
            "GenerationTransformer": [generation_transform_id]
        }
    }
    response = requests.post(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

def create_generation_artifact(artifact_id, validator_transform_id):
    url = f"{BASE_URL}/TrialArtifact"
    payload = {
        "TrialArtifact": {
            "ExtensionOf": artifact_id,
            "GenerationTransformer": [validator_transform_id]
        }
    }
    response = requests.post(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

def get_trial_artifact_by_id(artifact_id):
    url = f"{BASE_URL}/TrialArtifacts?airtableWhere=RECORD_ID()%3D'{artifact_id}'"
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()[0]

def write_prompt_to_file(prompt):
    # make response.txt say "prompt did not complete... :( try again"
    with open("response.txt", "w", encoding="utf-8") as file:
        file.write("prompt did not complete... :( try again")

    with open("prompt.txt", "w", encoding="utf-8") as file:
        file.write(prompt)

def run_gpt():
    os.system("gpt prompt.txt")

def read_response_from_file():
    with open("response.txt", "r", encoding="utf-8") as file:
        return file.read()

def update_trial_artifact(artifact):
    url = f"{BASE_URL}/TrialArtifact"
    payload = {
        "TrialArtifact": artifact
    }
    response = requests.put(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

def process_prompt_and_response(artifact, prompt_field, actual_prompt_field, response_field):
    suggested_prompt = artifact[prompt_field]
    write_prompt_to_file(suggested_prompt)
    run_gpt()
    actual_prompt = suggested_prompt
    response = read_response_from_file()
    artifact[actual_prompt_field] = actual_prompt
    artifact[response_field] = response
    return artifact

def root_prompt(iterations=1, transformer_number=1001):
    if (iterations > 1000):
        raise Exception("Iterations must be less than 1000")
    
    if (transformer_number < 1001):
        raise Exception("TransformNumber must be greater than 1000")

    print("Processing TransformerNumber:", transformer_number)
    generation_transform = get_generation_transform_by_number(transformer_number)
    if not generation_transform:
        print(f"No GenerationTransform found for TransformerNumber: {transformer_number}")
        return
    
    generation_transform_id = generation_transform["GenerationTransformerId"]
    for _ in range(iterations):
        print("Iterating...")
        created_artifact = create_trial_artifact(generation_transform_id)
        artifact_id = created_artifact["TrialArtifactId"]
        artifact = get_trial_artifact_by_id(artifact_id)
        
        # Process the initial prompt and response
        artifact = process_prompt_and_response(artifact, "SuggestedPrompt", "ActualPrompt", "Response")
        updated_artifact = update_trial_artifact(artifact)
        print("Artifact updated successfully:", updated_artifact)
        
        # Reload the artifact after the initial update
        artifact = get_trial_artifact_by_id(artifact_id)
        
        # Process the validation prompt and response
        artifact = process_prompt_and_response(artifact, "SuggestedValidationPrompt", "ActualValidationPrompt", "ValidationResponse")
        updated_artifact = update_trial_artifact(artifact)
        print("Validation artifact updated successfully:", updated_artifact)

def add_generation(iterations=1, validator_transform_number=1000, transformer_number=1001):
    generation_transform = get_generation_transform_by_number(validator_transform_number)
    if not generation_transform:
        print(f"No Validator GenerationTransform found for TransformerNumber: {validator_transform_number}")
        return
    
    generation_transform_id = generation_transform["GenerationTransformerId"]
        
    parent_artifacts = get_existing_artifact_without_validator(transformer_number)
    if not parent_artifacts:
        print(f"No existing artifacts without validator found for TransformerNumber: {transformer_number}")
        return
    
    for parent_artifact in parent_artifacts[:iterations]:
        parent_artifact_id = parent_artifact["TrialArtifactId"]

        generation_artifact = create_generation_artifact(parent_artifact_id, generation_transform_id)
        generation_artifact_id = generation_artifact["TrialArtifactId"]
        updated_artifact = get_trial_artifact_by_id(generation_artifact_id)

        parent_artifact = get_trial_artifact_by_id(parent_artifact_id)
        parent_artifact["PrimaryExtensionArtifact"] = generation_artifact_id
        update_trial_artifact(parent_artifact)

        print(updated_artifact)
        
        # Process the initial prompt and response
        updated_artifact = process_prompt_and_response(updated_artifact, "SuggestedPrompt", "ActualPrompt", "Response")
        updated_artifact = update_trial_artifact(updated_artifact)
        print("Validation Artifact updated successfully:", updated_artifact)
        
        # Reload the artifact after the initial update
        updated_artifact = get_trial_artifact_by_id(generation_artifact_id)
        
        # Process the validation prompt and response
        updated_artifact = process_prompt_and_response(updated_artifact, "SuggestedValidationPrompt", "ActualValidationPrompt", "ValidationResponse")
        updated_artifact = update_trial_artifact(updated_artifact)
        print("Validation artifact updated successfully:", updated_artifact)
        
        # print("Updated the artifact's PrimaryExtensionArtifact field")

if __name__ == "__main__":
    if len(sys.argv) < 3:
        print("Usage: add-data.py command iterations [generationTransformerNumber] transformerNumber")
        sys.exit(1)

    print("Trying to add data now...")
    
    command = sys.argv[1]
    if command == "add-root":
        iterations = int(sys.argv[2])
        source_transformer_number = int(sys.argv[3])
        root_prompt(iterations, source_transformer_number)
    elif command == "add-generation":
        iterations = int(sys.argv[2])
        generation_transform_number = int(sys.argv[3])
        source_transformer_number = int(sys.argv[4]) if len(sys.argv) > 4 else None
        add_generation(iterations, generation_transform_number,  source_transformer_number)
    else:
        print(f"Unknown command: {command}")
        sys.exit(1)
