#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Satoshi.Client.Web/Satoshi.Client.Web.csproj", "Satoshi.Client.Web/"]
COPY ["Satoshi.Shared.Common/Satoshi.Shared.Common.csproj", "Satoshi.Shared.Common/"]
COPY ["Satoshi.Core.Shared/Satoshi.Core.Shared.csproj", "Satoshi.Core.Shared/"]
RUN dotnet restore "Satoshi.Client.Web/Satoshi.Client.Web.csproj"
COPY . .
WORKDIR "/src/Satoshi.Client.Web"
RUN dotnet build "Satoshi.Client.Web.csproj" -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish "Satoshi.Client.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Satoshi.Client.Web.dll"]