#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/PetBrothers.API/PetBrothers.API.csproj", "src/PetBrothers.API/"]
COPY ["src/PetBrothers.Application/PetBrothers.Application.csproj", "src/PetBrothers.Application/"]
COPY ["src/PetBrothers.Domain/PetBrothers.Domain.csproj", "src/PetBrothers.Domain/"]
COPY ["src/PetBrothers.Infrastructure/PetBrothers.Infrastructure.csproj", "src/PetBrothers.Infrastructure/"]
RUN dotnet restore "./src/PetBrothers.API/PetBrothers.API.csproj"
COPY . .
WORKDIR "/src/src/PetBrothers.API"
RUN dotnet build "./PetBrothers.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PetBrothers.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PetBrothers.API.dll"]