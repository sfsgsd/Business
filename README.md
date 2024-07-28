# GymManagement

dotnet tool update --global dotnet-ef

dotnet ef database update

dotnet ef migrations add InitialCreate -p src\Business.Infrastructure -s src\Business.API

dotnet ef database update -p .\src\Business.Infrastructure -s src\Business.API

