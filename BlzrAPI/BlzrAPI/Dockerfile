FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BlzrAPI/BlzrAPI/BlzrAPI.csproj", "BlzrAPI/"]
RUN dotnet restore "BlzrAPI/BlzrAPI/BlzrAPI.csproj"
COPY . .
WORKDIR "/src/BlzrAPI"
RUN dotnet build "BlzrAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlzrAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlzrAPI.dll"]
