FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["app/MeuApp.csproj", "app/"]
RUN dotnet restore "app/MeuApp.csproj"
COPY . .
WORKDIR "/src/app"
RUN dotnet build "MeuApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MeuApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MeuApp.dll"]
