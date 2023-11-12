# Use the SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy the application files to the container
COPY ApiUtsNet/ .

# Build the app
RUN dotnet build -c Release -o /app/out

# Use a runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=build /app/out .

# COPY static files css, js, libs, etc
COPY ApiUtsNet/wwwroot /app/wwwroot

# Expose the port
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "ApiUtsNet.dll"]
