# Resume API DotNetCore

[![Build Status](https://jenkins.pedersen.io/buildStatus/icon?job=derekpedersen/resume-api-dotnetcore/master&style=plastic&.png)](https://jenkins.pedersen.io/job/derekpedersen/job/resume-api-dotnetcore/job/master/)
[![Coverage Status](https://coveralls.io/repos/github/derekpedersen/resume-api-dotnetcore/badge.png?branch=master)](https://coveralls.io/github/derekpedersen/resume-api-dotnetcore?branch=master)

This is the resume api written in dotnet core.

# API

This is a RESTful API that was written in C# targeting the dotnet core 2.0

## Resume Controller

The Resume Controller really is the entire show. 

### PDF Download

The Resume Controller provides the functionality to download my resume in the PDF format.

### JSON

The Resume Controller also returns a JSON representation of my resume.

# DotNetCore

https://docs.microsoft.com/en-us/dotnet/core/install/macos

# Docker

This project is deployed as a docker container

# Jenkins Pipelines

This repository uses two Jenkins pipeline files.

## CI Pipeline

- File: `Jenkinsfile`
- Purpose: checkout, test, and build only.
- Commands run: `make test`, `make build`.

## Deploy Pipeline

- File: `Jenkinsfile.deploy`
- Purpose: build, publish docker image, and deploy.
- Commands run: `make build`, `make docker`, `make publish`, `make deploy`.
- Deploy execution policy: runs only for manual builds or tag-triggered builds.

Credential usage in `Jenkinsfile.deploy` follows the same fallback pattern as the example repository:

- Docker publish credentials use `DOCKERHUB_CREDENTIALS_ID` when set, otherwise fallback to `docker-jenkins-pat`.
- Kubernetes kubeconfig credentials use `DOKS_KUBECONFIG_CREDENTIALS_ID` when set, otherwise fallback to `DOKS_KUBECONFIG`.

## Build

`docker build ./ -t resume-api-dotnetcore`

## Run

`docker run -d --rm -it -p 5000:5000 --name=resume-api-dotnetcore -t resume-api-dotnetcore`
