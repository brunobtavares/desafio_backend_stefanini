#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["desafio_backend_stefanini.API/desafio_backend_stefanini.API.csproj", "desafio_backend_stefanini.API/"]
COPY ["desafio_backend_stefanini.Application/desafio_backend_stefanini.Application.csproj", "desafio_backend_stefanini.Application/"]
RUN dotnet restore "desafio_backend_stefanini.API/desafio_backend_stefanini.API.csproj"
COPY . .
WORKDIR "/src/desafio_backend_stefanini.API"
RUN dotnet build "desafio_backend_stefanini.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "desafio_backend_stefanini.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "desafio_backend_stefanini.API.dll"]