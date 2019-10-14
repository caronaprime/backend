FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/Carona.Web/Carona.Web.csproj", "src/Carona.Web/"]
RUN dotnet restore "src/Carona.Web/Carona.Web.csproj"
COPY . .
WORKDIR "/src/src/Carona.Web"
RUN dotnet build "Carona.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Carona.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Carona.Web.dll"]