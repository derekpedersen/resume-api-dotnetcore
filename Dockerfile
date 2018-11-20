# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime

# Set working directory
WORKDIR /app

# Copy make build output
COPY ./src/out .

# Copy the resume files
COPY ./docs/resume/Derek_Pedersen_Resume.pdf .
ENV RESUME_PDF_FILE=Derek_Pedersen_Resume.pdf

EXPOSE 80

ENTRYPOINT ["dotnet", "resume-api-dotnetcore.dll"]