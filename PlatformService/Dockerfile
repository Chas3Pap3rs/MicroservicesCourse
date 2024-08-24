FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application files and publish
COPY . ./
RUN dotnet publish -c Release -o out ./PlatformService.csproj

# Use the ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build-env /app/out .

# Set the entry point to run the application
ENTRYPOINT [ "dotnet", "PlatformService.dll" ]
