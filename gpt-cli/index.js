#!/usr/bin/env node

const fs = require('fs');
const https = require('https');

// Load API key from environment variable
const apiKey = process.env.OPENAI_API_KEY;

// Get the filename from the command line arguments
const fileName = process.argv[2]; // This will read the second argument (e.g., "prompt.txt")
const prompt = fs.readFileSync(fileName, "utf8");

// Load the system message from system-message.txt
const systemMessage = fs.readFileSync('system-message.txt', 'utf8');

// API settings
const hostname = 'api.openai.com';
const path = '/v1/chat/completions';
const model = "gpt-4o"; // Updated model name

const data = JSON.stringify({
  model: model,
  messages: [
    { role: "system", content: systemMessage },
    { role: "user", content: prompt }
  ],
  max_tokens: 1000,
  temperature: 0.5
});

const options = {
  hostname: hostname,
  port: 443,
  path: path,
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
    'Authorization': `Bearer ${apiKey}`,
    'Content-Length': data.length
  }
};

// Send the prompt to the API using an HTTPS POST request
function sendPrompt() {
  console.log('Sending request with data:', data); // Log the data being sent
  const req = https.request(options, (res) => {
    let response = '';
    res.on('data', (chunk) => {
      response += chunk;
    });
    res.on('end', () => {
      console.log('Raw response:', response); // Log the raw response for debugging
      try {
        const json = JSON.parse(response);
        if (json.choices && json.choices.length > 0) {
          const finalResponse = json.choices[0].message.content;
          console.log(finalResponse);
          // Save the response to response.txt
          fs.writeFileSync('response.txt', finalResponse);
        } else {
          console.error('Unexpected API response structure:', json);
        }
      } catch (err) {
        console.error('Error parsing JSON!', err);
      }
    });
  });

  req.on('error', (error) => {
    console.error('Request Error:', error);
  });

  req.write(data);
  req.end();
}

sendPrompt();
