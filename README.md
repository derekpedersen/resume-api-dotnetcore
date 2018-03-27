# resume - api - dotnetcore

This is the resume api written in dotnet core.

# Docker

## Build
- docker build ./ -t resume-api-dotnetcore

## Run
- docker run -d --rm -it -p 5000:5000 --name=resume-api-dotnetcore -t resume-api-dotnetcore

## GCR
- docker tag resume-api-dotnetcore us.gcr.io/derekpedersen-195304/resume-api-dotnetcore:latest
- gcloud docker -- push us.gcr.io/derekpedersen-195304/resume-api-dotnetcore:latest
