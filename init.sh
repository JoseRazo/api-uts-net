#!/bin/bash

# Crea la aplicación ASP.NET Core
dotnet new webapi -n ApiUtsNet -o /app/ApiUtsNet

# Cambia al directorio de la aplicación
cd /app/ApiUtsNet

chmod -R 777 /app/ApiUtsNet

# Inicia una shell interactiva
/bin/bash
