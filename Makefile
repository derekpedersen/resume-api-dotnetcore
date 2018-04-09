local:
	dotnet restore ./src/resume-api-dotnetcore.csproj
	dotnet publish ./src/resume-api-dotnetcore.csproj -c Release -o out

run:
	dotnet ./src/out/resume-api-dotnetcore.dll

build:
	docker build ./ -t resume-api-dotnetcore

publish:
	docker tag resume-api-dotnetcore us.gcr.io/derekpedersen-195304/resume-api-dotnetcore:latest
	gcloud docker -- push us.gcr.io/derekpedersen-195304/resume-api-dotnetcore:latest

deploy:
	kubectl delete deployment resume-api-dotnetcore-deployment
	kubectl create -f ./kubernetes/deployment.yaml
	kubectl apply -f ./kubernetes/service.yaml