import requests

def read_prompt_file(file_path):
    try:
        with open(file_path, 'r') as file:
            return file.read()
    except IOError as e:
        print(f"Error reading {file_path}: {e}")
        return None

def post_data_and_save_response(api_url, api_key, model, prompt_text):
    payload = {
        "key": api_key,
        "model": model,
        "prompt": prompt_text
    }
    try:
        response = requests.post(api_url, json=payload)
        response.raise_for_status()  # Raises an HTTPError if the response was an HTTP error
        return response.text
    except requests.RequestException as e:
        print(f"HTTP Request failed: {e}")
        return None

def save_response_to_file(file_path, response_text):
    try:
        with open(file_path, 'w') as file:
            file.write(response_text)
    except IOError as e:
        print(f"Error writing to {file_path}: {e}")

def main():
    prompt_text = read_prompt_file("C://Users//auto1//go//src//github.com//eejai42//advent-of-code-2023//research//python//prompt.txt")
    if prompt_text is not None:
        response_text = post_data_and_save_response("https://k6vipu7segkzalfaaras5nuanu0oigwp.lambda-url.us-east-2.on.aws/", "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", "gpt-3.5-turbo", prompt_text)
        if response_text is not None:
            save_response_to_file("response.txt", response_text)

if __name__ == "__main__":
    main()
