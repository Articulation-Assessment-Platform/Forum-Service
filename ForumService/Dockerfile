#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5200
EXPOSE 5201

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/..
COPY ["ForumAPI/ForumAPI.csproj", "ForumAPI/"]
COPY ["ForumTest/ForumTest.csproj", "ForumTest/"]
RUN dotnet restore "./ForumAPI/ForumAPI.csproj"
COPY . .
WORKDIR "/src/.."
RUN dotnet build "ForumAPI/ForumAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ForumAPI/ForumAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ForumAPI.dll"] 
