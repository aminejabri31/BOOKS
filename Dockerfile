FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /code
COPY . .
RUN dotnet restore BooksEcommerce-master\\BooksEcommerce.sln
RUN dotnet publish --output /output --configuration Release
FROM mcr.microsoft.com/dotnet/aspnet:7.0
COPY --from=build /output /app
WORKDIR /app
ENTRYPOINT ["dotnet", "BooksEcommerce.dll"]
