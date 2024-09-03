import requests
import os
import json
import time

def download_file(url, filename):
    # Ensure the directory exists
    os.makedirs(os.path.dirname(filename), exist_ok=True)
    
    # Get the response from the URL
    response = requests.get(url)
    response.raise_for_status()  # Raise an exception for HTTP errors
    
    # Write the content to a file
    with open(filename, 'wb') as f:
        f.write(response.content)
    print(f"Downloaded {filename}")

def process_data_flow(data_flow, base_path="C:/syntax-free-research/the-joneses/martini-scroller-app/public/transpiler-images/"):
    attachment_fields = [key for key in data_flow if key.endswith('Attachments')]
    for field in attachment_fields:
        attachments = data_flow[field]
        for index, url in enumerate(attachments):
            filename = os.path.join(base_path, data_flow['FromNodeName'].replace(' ', '_'), f"{data_flow['EdgeName'].replace(' ', '_')}_{field}_{index}.png")
            download_file(url, filename)
            # sleep for 250ms
            time.sleep(0.25)

def main():
    data_file_path = "C:/syntax-free-research/the-joneses/martini-scroller-app/public/demo-flow.json"
    with open(data_file_path, 'r') as file:
        data_flows = json.load(file)
        for data_flow in data_flows['DataFlow']:
            process_data_flow(data_flow)

if __name__ == "__main__":
    main()
