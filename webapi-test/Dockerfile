﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["webapi-test/webapi-test.csproj", "webapi-test/"]
RUN dotnet restore "webapi-test/webapi-test.csproj"
COPY . .
WORKDIR "/src/webapi-test"
RUN dotnet build "webapi-test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "webapi-test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webapi-test.dll"]
