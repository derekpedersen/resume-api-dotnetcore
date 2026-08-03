export GIT_COMMIT_SHA = $(shell git rev-parse HEAD)

local:
	dotnet restore ./api/api.csproj
	dotnet publish ./api/api.csproj -c Release -o out

test:
	cd tests && dotnet test --collect:"XPlat Code Coverage"
	
run:
	dotnet ./api/out/api.dll

build:
	cd api && \
	dotnet restore && \
	dotnet publish -c Release -o out

docker:
	docker build ./ -t resume-api-dotnetcore

publish:
	docker tag resume-api-dotnetcore derekpedersen/resume-api-dotnetcore:${GIT_COMMIT_SHA}
	docker push derekpedersen/resume-api-dotnetcore:${GIT_COMMIT_SHA}

set-version:
	./.tools/set-version.sh
	
deploy: set-version
	helm upgrade --install resume-api-dotnetcore .helm

release: test build docker publish deploy