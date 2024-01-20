# Step 1: Run the command and save the latest-test-run.json
syntax-free addtestrun -bodyfile .\addtestrun.json > latest-test-run.json

# Step 2: Read the PromptVariationFinalPrompt from latest-test-run.json
$testRunJson = Get-Content -Raw latest-test-run.json | ConvertFrom-Json
$finalPrompt = $testRunJson.TestRun.PromptVariationFinalPrompt

# Step 3: Save the PromptVariationFinalPrompt to ../python/prompt.txt
$finalPrompt | Set-Content -Path ..\python\prompt.txt

# Step 4: Run ../python/prompt.py
# Note: You'll need to execute the Python script here manually as it's an external script.

# Step 5: Read ../python/response.txt
$response = Get-Content -Raw ..\python\response.json

# Step 6: Update the Response attribute in latest-test-run.json
$testRunJson.TestRun.Response = $response | Out-String
$testRunJson | ConvertTo-Json | Set-Content -Path latest-test-run.json

# Step 7: Run the command to update the test run
syntax-free updatetestrun -bodyfile latest-test-run.json
