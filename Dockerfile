FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Abp.UI.csproj .
RUN dotnet restore Abp.UI.csproj
COPY . .
WORKDIR /src/
RUN dotnet build Abp.UI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Abp.UI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Abp.UI.dll"]