# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY LandingDB/LandingDB.csproj LandingDB/
COPY LandingDB.sln ./
RUN dotnet restore

# Copy everything else
COPY . .

# Publish app
RUN dotnet publish LandingDB/LandingDB.csproj -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Environment + exposed port
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

# Run the app (adjust DLL name if different)
ENTRYPOINT ["dotnet", "LandingDB.dll"]