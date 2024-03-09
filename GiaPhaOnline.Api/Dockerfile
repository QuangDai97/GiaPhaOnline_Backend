FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GiaPhaOnline.Api/GiaPhaOnline.Api.csproj", "GiaPhaOnline.Api/"]
RUN dotnet restore "GiaPhaOnline.Api/GiaPhaOnline.Api.csproj"
COPY . .
WORKDIR "/src/GiaPhaOnline.Api"
RUN dotnet build "GiaPhaOnline.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GiaPhaOnline.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GiaPhaOnline.Api.dll"]
