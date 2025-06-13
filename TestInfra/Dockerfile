FROM mcr.microsoft.com/dotnet/sdk:9.0 AS base
WORKDIR /app
COPY . ./
RUN dotnet restore
RUN dotnet publish -c RELEASE -o bin
SHELL ["/bin/bash", "-c"]
ENTRYPOINT dotnet test
