# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet

# Set working directory
WORKDIR /app

# Copy make build output
COPY ./api/out .

# Copy the resume files
COPY ./docs/resume/Derek_Pedersen_Resume.pdf .
ENV RESUME_PDF_FILE=Derek_Pedersen_Resume.pdf
ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80

ENTRYPOINT ["dotnet", "api.dll"]