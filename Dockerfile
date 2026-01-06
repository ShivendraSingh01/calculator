# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY *.sln .
COPY src ./src
COPY tests ./tests

RUN dotnet restore
RUN dotnet publish src/Calculator/Calculator.csproj \
    -c Release \
    -o /out

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /out .

ENTRYPOINT ["dotnet", "Calculator.dll"]
