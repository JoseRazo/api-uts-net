# api-uts-net
API UTS CREADA EN .NET

## Pre-requisitos

- Instalar [Docker.](https://www.docker.com/get-started)
- Instalar [Docker Compose.](https://docs.docker.com/compose/install/)

## Instalación

- Clonar repositorio `git clone https://github.com/JoseRazo/api-uts-net.git`
- Generar imagen docker y contenedores con **`docker-compose build`** y **`docker-compose up -d`**

## Crear app si aún no está creada

- Generar imagen **`docker compose -f docker-compose-new-app.yml build`**
- Correr contenedor para que se cree la carpeta con la app **`docker compose -f docker-compose-new-app.yml up`**
- Estos comandos crearán la carpeta y los archivos de la aplicación.

## Abrir proyecto

Abrir navegador y entrar a URL [127.0.0.1:5200](http://127.0.0.1:5200)
