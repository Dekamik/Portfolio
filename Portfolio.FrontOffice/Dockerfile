#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Portfolio.FrontOffice/Portfolio.FrontOffice.csproj", "Portfolio.FrontOffice/"]
COPY ["Portfolio.Core/Portfolio.Core.csproj", "Portfolio.Core/"]
COPY ["Portfolio.Common.Api/Portfolio.Common.Api.csproj", "Portfolio.Common.Api/"]
COPY ["Portfolio.Common/Portfolio.Common.csproj", "Portfolio.Common/"]
COPY ["Portfolio.BusinessLogic/Portfolio.BusinessLogic.csproj", "Portfolio.BusinessLogic/"]
RUN dotnet restore "Portfolio.FrontOffice/Portfolio.FrontOffice.csproj"
COPY . .
WORKDIR "/src/Portfolio.FrontOffice"
RUN dotnet build "Portfolio.FrontOffice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Portfolio.FrontOffice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Portfolio.FrontOffice.dll"]