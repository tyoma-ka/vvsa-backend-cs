# Setup

## Dependencies
```bash
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Mysql.EntityFrameworkCore --version 10.0.0-rc
dotnet restore
```

## Run
```bash
dotnet run
```

## API Documentation
Scalar UI: `http://localhost:5036/scalar/v1`  
OpenAPI spec: `http://localhost:5036/openapi/v1.json`  