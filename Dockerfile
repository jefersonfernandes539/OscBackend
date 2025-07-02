# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["OscBackend.csproj", "."]
RUN dotnet restore "OscBackend.csproj"

COPY . .
RUN dotnet publish "OscBackend.csproj" -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Agora sim você pode usar ContainerUser, se quiser
# USER ContainerUser

ENTRYPOINT ["dotnet", "OscBackend.dll"]
