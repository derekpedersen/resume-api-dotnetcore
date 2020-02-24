export GIT_COMMIT_SHA = $(shell git rev-parse HEAD)

local:
	dotnet restore ./src/resume-api-dotnetcore.csproj
	dotnet publish ./src/resume-api-dotnetcore.csproj -c Release -o out

test:
	cd tests && dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=\"cobertura,opencover\"

run:
	dotnet ./src/out/resume-api-dotnetcore.dll

build:
	cd src && \
	dotnet restore && \
	dotnet publish -c Release -o out

docker:
	docker build ./ -t resume-api-dotnetcore

publish:
	docker tag resume-api-dotnetcore us.gcr.io/sleipnir/resume-api-dotnetcore:${GIT_COMMIT_SHA}
	gcloud docker -- push us.gcr.io/sleipnir/resume-api-dotnetcore:${GIT_COMMIT_SHA}

kubernetes: build docker publish deploy