# Use the official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY app.csproj ./
RUN dotnet restore

# Copy the remaining files and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/out ./

# Set the entry point
ENTRYPOINT ["dotnet", "app.dll"]
