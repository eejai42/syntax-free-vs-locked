# Variables (adjust as needed)
$cluster = "Effortless42"
$servicename = "ej-syntax-locked-vs-syntax-free-rest-api"
$port = 42016
$profile = "default"
$region = "us-east-2"
$memory = 2048
$executionrolearn = "arn:aws:iam::889457909864:role/ecsTaskExecutionRole"
$awsid = "889457909864"
$registry = "$awsid.dkr.ecr.$region.amazonaws.com"
$localImage = """$($servicename):latest"""
$targetImage = """$($registry)/$($servicename):latest"""
write-host docker tag $localImage $targetImage

#write-host docker tag " """$servicename":latest"" """$registry"/"$servicename":latest"""
# Check if the repository exists to avoid creating it again
write-host aws ecr create-repository --repository-name $servicename --profile $profile --region $region
aws ecr create-repository --repository-name $servicename --profile $profile --region $region
try {
    $repoExists = aws ecr describe-repositories --repository-names $servicename --region $region --profile $profile
} catch {
    aws ecr create-repository --repository-name $servicename --profile $profile --region $region
}

# AWS ECR - Login
$loginPassword = aws ecr get-login-password --profile $profile --region $region
docker login --username AWS --password $loginPassword $registry

# Docker - Build, tag, and push
docker build -f .\ASPNet-REST-API\Dockerfile . -t $servicename
docker-compose build
docker tag $localImage $targetImage

write-host docker push $targetImage
docker push $targetImage

# AWS ECS - Register task definition
$containerDefinition = @"
[
    {
        """name""":"""$($servicename)""",
        """image""":"""$awsid.dkr.ecr.$region.amazonaws.com/$($servicename):latest""",
        """essential""":true,
        """memory""":$memory,
        """memoryReservation""":16,
         """portMappings""": [
                {
                  """protocol""": """tcp""",
                  """hostPort""": $port,
                  """containerPort""": $port
                }
        ],
        """logConfiguration""": {
            """logDriver""": """awslogs""",
            """options""": {
                """awslogs-group""": """/ecs/$($servicename)""",
                """awslogs-region""": """$region""",
                """awslogs-stream-prefix""": """ecs"""
            }
        }
    }
]
"@

write-host "WRITING HOST CONTAINER DEFINITION" $containerDefinition

aws ecs register-task-definition --profile $profile --region $region --family $servicename --execution-role-arn $executionrolearn --requires-compatibilities "EC2" --container-definitions $containerDefinition

# Create or update service
try {
    aws ecs create-service --profile $profile --region $region --cluster $cluster --service-name $servicename --task-definition $servicename --desired-count 1 --launch-type "EC2"
} catch {
    aws ecs update-service --profile $profile --region $region --service $servicename --cluster $cluster --task-definition $servicename
}
