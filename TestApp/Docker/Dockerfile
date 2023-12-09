FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY  publish/ .
ENTRYPOINT ["dotnet", "TestApp.dll"]