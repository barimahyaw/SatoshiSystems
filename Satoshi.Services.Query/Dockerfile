#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Satoshi.Services.Query/Satoshi.Services.Query.csproj", "Satoshi.Services.Query/"]
COPY ["Satoshi.Core/Satoshi.Core.csproj", "Satoshi.Core/"]
COPY ["Sotashi.Core.Infastructure/Sotashi.Core.Infastructure.csproj", "Sotashi.Core.Infastructure/"]
COPY ["Satoshi.Core.Shared/Satoshi.Core.Shared.csproj", "Satoshi.Core.Shared/"]
COPY ["Satoshi.Shared.Common/Satoshi.Shared.Common.csproj", "Satoshi.Shared.Common/"]
RUN dotnet restore "Satoshi.Services.Query/Satoshi.Services.Query.csproj"
COPY . .
WORKDIR "/src/Satoshi.Services.Query"
RUN dotnet build "Satoshi.Services.Query.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Satoshi.Services.Query.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Satoshi.Services.Query.dll"]
