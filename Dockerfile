FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
# 2025/07/27 Bruce 修改 EXPOSE 80 => 8080
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CICD_Demo.dll"]