FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 5000
EXPOSE 5050

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/OrderMicroservice.API/OrderMicroservice.API.csproj", "src/OrderMicroservice.API/"]
COPY ["src/OrderMicroservice.Application/OrderMicroservice.Application.csproj", "src/OrderMicroservice.Application/"]
COPY ["src/OrderMicroservice.Domain/OrderMicroservice.Domain.csproj", "src/OrderMicroservice.Domain/"]
RUN dotnet restore "src/OrderMicroservice.API/OrderMicroservice.API.csproj"
COPY . .
WORKDIR "/src/src/OrderMicroservice.API"
RUN dotnet build "OrderMicroservice.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "OrderMicroservice.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderMicroservice.API.dll"]
