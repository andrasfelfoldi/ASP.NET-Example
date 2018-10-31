FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 58950
EXPOSE 44334

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ASP.NET Example/ASP.NET Example.csproj", "ASP.NET Example/"]
RUN dotnet restore "ASP.NET Example/ASP.NET Example.csproj"
COPY . .
WORKDIR "/src/ASP.NET Example"
RUN dotnet build "ASP.NET Example.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ASP.NET Example.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ASP.NET Example.dll"]