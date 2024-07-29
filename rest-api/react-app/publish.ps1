ng build
aws --profile default s3 sync ./dist s3://www.demos.aicapture.io --delete --content-type "application/javascript" --exclude "*" --include "*.js"
aws --profile default s3 sync ./dist s3://www.demos.aicapture.io --delete
aws --profile default cloudfront create-invalidation --distribution-id E3LBUY9P5HS0OF --paths "/*"
