FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["FilesStorage.Api.Write.csproj", "FilesStorage.Api.Write/"]
RUN dotnet restore "FilesStorage.Api.Write/FilesStorage.Api.Write.csproj"

WORKDIR "/src/FilesStorage.Api.Write"
COPY . .

RUN dotnet build "FilesStorage.Api.Write.csproj" -c Release -o /app/build

FROM build AS publish       
RUN dotnet publish "FilesStorage.Api.Write.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "/app/FilesStorage.Api.Write.dll", "--server.urls", "https://0.0.0.0:443"]