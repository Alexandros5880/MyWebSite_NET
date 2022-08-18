FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
COPY ["MyWebSite.csproj", "MyWebSite/"]
COPY Setup.sh Setup.sh
RUN dotnet tool install --global dotnet-ef --version 5.0.12
RUN dotnet restore "MyWebSite/MyWebSite.csproj"
WORKDIR "/src/MyWebSite"
COPY . .
RUN /root/.dotnet/tools/dotnet-ef migrations add InitialMigrations
RUN chmod +x ./Setup.sh
CMD /bin/bash ./Setup.sh