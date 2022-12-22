FROM mcr.microsoft.com/dotnet/sdk:6.0.401 AS build-env
WORKDIR /app
COPY . .
# Copy csproj and restore as distinct layers
RUN dotnet restore "CustomerData.App.Mvc.csproj"
COPY . .

RUN dotnet build "CustomerData.App.Mvc.csproj" -c Release -o /app/build

# Copy everything else and build

FROM build-env AS publish
RUN dotnet publish "CustomerData.App.Mvc.csproj" -c Release -o /app/publish  -r win-x64 --self-contained false

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","CustomerData.App.Mvc.dll"]