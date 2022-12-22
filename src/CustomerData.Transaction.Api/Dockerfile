FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
COPY . .

# Copy csproj and restore as distinct layers
RUN dotnet restore -s "https://api.nuget.org/v3/index.json" "CustomerData.Transaction.Api/CustomerData.Transaction.Api.csproj"
COPY . .

RUN dotnet build "CustomerData.Transaction.Api/CustomerData.Transaction.Api.csproj" -c Release -o /app/build -r alpine.3.16-x64

# Copy everything else and build

FROM build-env AS publish
RUN dotnet publish "CustomerData.Transaction.Api/CustomerData.Transaction.Api.csproj" -c Release -o /app/publish -r alpine.3.16-x64 /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime-deps:6.0.9-alpine3.16
WORKDIR /app
COPY --from=publish /app/publish ./CustomerData.Transaction.Api

EXPOSE 80
ENTRYPOINT ["./CustomerData.Transaction.Api"]