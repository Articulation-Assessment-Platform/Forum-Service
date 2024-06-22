#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ForumAPI/ForumAPI.csproj", "ForumAPI/"]
<<<<<<< HEAD
=======
COPY ["../../RepositoryLayer/RepositoryLayer.csproj", "RepositoryLayer/"]
COPY ["../../ServiceLayer/ServiceLayer.csproj", "ServiceLayer/"]
>>>>>>> ae699fa574a019d5d45e41e126d93c58d66fde48
RUN dotnet restore "./ForumAPI/ForumAPI.csproj"
COPY . .
WORKDIR "/src/ForumAPI"
RUN dotnet build "./ForumAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ForumAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForumAPI.dll"]
