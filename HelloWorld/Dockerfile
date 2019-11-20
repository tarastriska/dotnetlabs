FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS base
WORKDIR /app

# Build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
COPY . ./
WORKDIR /HelloWorld
RUN dotnet build -c Release

# Publish
FROM build AS publish
WORKDIR /HelloWorld
RUN dotnet publish -c Release -o /app --no-build

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HelloWorld.dll"]