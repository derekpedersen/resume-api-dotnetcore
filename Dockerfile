FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy everything else and build
COPY ./src/ ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore-build:2.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "resume-api-dotnetcore.dll"]