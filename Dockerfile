FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

COPY Back/Techno_King.sln Back/

COPY Back/App.Domain.Core/App.Domain.Core.csproj Back/App.Domain.Core/
COPY Back/App.Infra.Data.Repos.Ef/App.Infra.Data.Repos.Ef.csproj Back/App.Infra.Data.Repos.Ef/
COPY Back/Connection/Connection.csproj Back/Connection/
COPY Back/Techno_KingAppService/Techno_KingAppService.csproj Back/Techno_KingAppService/
COPY Back/Techno_KingService/Techno_KingService.csproj Back/Techno_KingService/
COPY Back/Techno_King_WebAPI/Techno_King_WebAPI.csproj Back/Techno_King_WebAPI/

RUN dotnet restore Back/Techno_King.sln

COPY Back/ Back/

RUN dotnet publish \
    Back/Techno_King_WebAPI/Techno_King_WebAPI.csproj \
    -c Release \
    -o /app/publish \
    --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final

WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Techno_King_WebAPI.dll"]
