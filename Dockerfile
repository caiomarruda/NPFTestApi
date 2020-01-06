FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/NPFTestApi/NPFTestApi.csproj", "src/NPFTestApi/"]
RUN dotnet restore "src/NPFTestApi/NPFTestApi.csproj"
COPY . .
WORKDIR "/src/src/NPFTestApi"
RUN dotnet build "NPFTestApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NPFTestApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NPFTestApi.dll"]