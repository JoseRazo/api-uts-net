# Use the .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Set the environment to development
ENV ASPNETCORE_ENVIRONMENT=Development

# Install the Entity Framework Core tools
RUN dotnet tool install --global dotnet-ef --version 7.0.0

# Copy only the project file and restore dependencies
COPY ApiUtsNet/*.csproj .
RUN dotnet restore

# Install Microsoft.EntityFrameworkCore.SqlServer
RUN dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0

# Copy all files to the container from the ApiUtsNet folder
COPY ApiUtsNet/ .

# Expose the default port (change if your app uses a different port)
EXPOSE 5000

# Use 'CMD' to run the application with 'dotnet watch run'
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:5000"]
