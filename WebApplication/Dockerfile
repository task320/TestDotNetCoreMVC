FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["./WebApplication.csproj", "WebApplication/"]
RUN dotnet restore "WebApplication/WebApplication.csproj"
COPY . WebApplication/
WORKDIR "/src/WebApplication"
RUN dotnet build "WebApplication.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApplication.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS="http://*:5000"
ENTRYPOINT ["dotnet", "WebApplication.dll"]