#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM node:10.15-alpine AS client 
ARG skip_client_build=false 
WORKDIR /app 
COPY desafio_backend_stefanini/ClientApp . 
RUN [[ ${skip_client_build} = true ]] && echo "Skipping npm install" || npm install 
RUN [[ ${skip_client_build} = true ]] && mkdir dist || npm run-script build

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["desafio_backend_stefanini/desafio_backend_stefanini.csproj", "desafio_backend_stefanini/"]
COPY ["desafio_backend_stefanini.Application/desafio_backend_stefanini.Application.csproj", "desafio_backend_stefanini.Application/"]
RUN dotnet restore "desafio_backend_stefanini/desafio_backend_stefanini.csproj"
COPY . .
WORKDIR "/src/desafio_backend_stefanini"
RUN dotnet build "desafio_backend_stefanini.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "desafio_backend_stefanini.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=client /app/dist /app/dist
ENTRYPOINT ["dotnet", "desafio_backend_stefanini.dll"]