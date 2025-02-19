FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5125
ENV ASPNETCORE_URLS=http://+:5125

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "eGostujucaPredavanja.API/eGostujucaPredavanja.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "eGostujucaPredavanja.API.dll"]