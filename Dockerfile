# Build runtime image
FROM microsoft/aspnetcore-build:2.0

WORKDIR /app

COPY ./src/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "resume-api-dotnetcore.dll"]