FROM mcr.microsoft.com/dotnet/core/sdk:3.1
EXPOSE 3000
WORKDIR /app
COPY . .
RUN dotnet restore
ENTRYPOINT ["dotnet", "run"]
