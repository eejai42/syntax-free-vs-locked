import requests
import json

# Define REST API endpoint and headers
REST_BEARER_TOKEN = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6Imdvb2dsZS1vYXV0aDJ8MTA1NzYwMDM4MzgyNzgzMTI0MTYxIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZSI6IkVKIEFsZXhhbmRyYSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6ImVlamFpNDJAZ21haWwuY29tIiwicGljdHVyZSI6Imh0dHBzOi8vbGgzLmdvb2dsZXVzZXJjb250ZW50LmNvbS9hL0FDZzhvY0kxbWFHeXVIUG5tSWFFbG40cVI5UXFaUFdMX3NMLVZabmVfd1ZxeUV4bXg4b2JRYWJ6bXc9czk2LWMiLCJlbWFpbF92ZXJpZmllZCI6IlRydWUiLCJleHAiOjE3MjI4NjgwOTYsImlzcyI6ImVqLXRpY3RhY3RvZS1kZW1vLnVzLmF1dGgwLmNvbSIsImF1ZCI6Imh0dHBzOi8vZWotdGljdGFjdG9lLWRlbW8udXMuYXV0aDAuY29tL2FwaS92MiJ9.vzbd2vFYnz_WJ1yKLynjMFcp3ZBEvBXSY06yaBH6_Ck"
BASE_URL = "https://localhost:42016/User"
HEADERS = {
    "Authorization": f"Bearer {REST_BEARER_TOKEN}",
    "Content-Type": "application/json"
}

def load_trial_artifacts_without_trial():
    url = f"{BASE_URL}/TrialArtifacts?view=WithoutTrial&maxPages=100"
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    return response.json()

def update_custom_root_identifiers(artifacts):
    for root_artifact in artifacts:
        if root_artifact.get('ExtensionOf') is not None:
            continue

        # Start with the root artifact and initialize the chain
        root_id = root_artifact['ArtifactIdentifier']
        current_artifact = root_artifact
        max_artifacts = 10
        while current_artifact is not None:
            if max_artifacts == 0:
                break
            max_artifacts -= 1

            # Find the next artifact, that is an ExtensionOf current_artifact["TrialArtifactId"]
            next_artifact = None
            for artifact in artifacts:
                if artifact.get('ExtensionOf') == current_artifact['TrialArtifactId']:
                    next_artifact = artifact
                    break

            current_artifact = next_artifact

            if next_artifact is None:
                break

            # Update the CustomRootIdentifier for the current artifact
            next_artifact['CustomRootIdentifier'] = root_id
            update_trial_artifact(next_artifact)


def update_trial_artifact(artifact):
    url = f"{BASE_URL}/TrialArtifact"
    print(url, artifact.get('Name'))
    payload = {
        "TrialArtifact": artifact
    }
    response = requests.put(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()

def create_artifact_analysis(artifact_id):
    url = f"{BASE_URL}/ArtifactAnalysis"
    payload = {
        "ArtifactAnalysis": {
            "TrialArtifact": artifact_id
        }
    }
    response = requests.post(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()

def link_previous_generations(artifact_analysis):
    sorted_analysis = sorted(artifact_analysis, key=lambda x: (x['RootArtifactIdentifier'], x['GenerationName']))
    print("UPDATING PREVIOUS GENERATIONS: ", sorted_analysis[0]['Name'])
    for i in range(1, len(sorted_analysis)):
        artifact = sorted_analysis[i]
        if artifact.get('TransformerGeneratioNumber') is not None and \
                        artifact.get('TransformerGeneratioNumber') <= 1:
            print("\n\nNOT UPDATING: ", artifact['Name'])
            continue
        print(artifact['Name'])
        artifact['PreviousGeneration'] = sorted_analysis[i - 1]['ArtifactAnalysisId']
        update_artifact_analysis(artifact)

def update_artifact_analysis(analysis):
    url = f"{BASE_URL}/ArtifactAnalysis"
    payload = { "ArtifactAnalysis": analysis }
    response = requests.put(url, json=payload, headers=HEADERS, verify=False)
    response.raise_for_status()

def get_all_artifact_analysis():
    url = f"{BASE_URL}/ArtifactAnalyses?airtableWhere=AND(Trial%3dBlank())"
    response = requests.get(url, headers=HEADERS, verify=False)
    response.raise_for_status()
    artifacts = response.json()
    print("ARTIFACTS NOT GENERATION 1", len(artifacts))
    return artifacts

def main():
    # Load and process TrialArtifacts
    trial_artifacts = load_trial_artifacts_without_trial()
    update_custom_root_identifiers(trial_artifacts)
    
    # Create ArtifactAnalysis records
    for artifact in trial_artifacts:
        if 'ArtifactAnalysis' in artifact and artifact["ArtifactAnalysis"] is not None:
            continue
        create_artifact_analysis(artifact['TrialArtifactId'])
    
    # Load ArtifactAnalysis data
    artifact_analysis = get_all_artifact_analysis()
    
    # Link previous generations
    link_previous_generations(artifact_analysis)

if __name__ == "__main__":
    main()
