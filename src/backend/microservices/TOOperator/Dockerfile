#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/backend/microservices/TOOperator/TOOperator.csproj", "src/backend/microservices/TOOperator/"]
RUN dotnet restore "src/backend/microservices/TOOperator/TOOperator.csproj"
COPY . .
WORKDIR "/src/src/backend/microservices/TOOperator"
RUN dotnet build "TOOperator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TOOperator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TOOperator.dll"]