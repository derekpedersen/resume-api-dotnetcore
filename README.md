# resume - api - dotnetcore

[![Build Status](https://jenkins.derekpedersen.com/buildStatus/icon?job=derekpedersen/resume-api-dotnetcore/master&style=plastic&.png)](https://jenkins.derekpedersen.com/job/derekpedersen/job/resume-api-dotnetcore/job/master/)
[![Coverage Status](https://coveralls.io/repos/github/derekpedersen/resume-api-dotnetcore/badge.png?branch=master)](https://coveralls.io/github/derekpedersen/resume-api-dotnetcore)


This is the resume api written in dotnet core.

# Docker

## Build
- docker build ./ -t resume-api-dotnetcore

## Run
- docker run -d --rm -it -p 5000:5000 --name=resume-api-dotnetcore -t resume-api-dotnetcore

## GCR
- docker tag resume-api-dotnetcore us.gcr.io/${GCLOUD_PROJECT_ID}/resume-api-dotnetcore:latest
- gcloud docker -- push us.gcr.io/${GCLOUD_PROJECT_ID}/resume-api-dotnetcore:latest
