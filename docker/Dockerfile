# Etapa de construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar os arquivos de projeto e restaurar dependências
COPY ./app/*.csproj ./
RUN dotnet restore

# Copiar o restante dos arquivos da aplicação
COPY ./app/. ./

# Compilar a aplicação
RUN dotnet publish -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./

# Comando para executar a aplicação
ENTRYPOINT ["dotnet", "MeuApp.dll"]
