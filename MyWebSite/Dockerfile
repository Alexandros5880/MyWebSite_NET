FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MyWebSite.csproj", "MyWebSite/"]
RUN dotnet restore "MyWebSite/MyWebSite.csproj"
WORKDIR "/src/MyWebSite"
COPY . .
RUN dotnet build "MyWebSite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyWebSite.csproj" -c Release -o /app/publish

# Add Migrations
#RUN dotnet tool install -g dotnet-ef --version 5.0.12
#ENV PATH $PATH:/root/.dotnet/tools
#RUN dotnet ef --version
#RUN dotnet ef migrations add Initial
#RUN chmod +x ./Setup.sh
#CMD /bin/bash ./Setup.sh
# End Adding Migrations

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chmod 777 /app
ENTRYPOINT ["dotnet", "MyWebSite.dll"]