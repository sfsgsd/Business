# GymManagement

dotnet tool update --global dotnet-ef

dotnet ef database update

dotnet ef migrations add InitialCreate -p src\Infrastructure -s src\API

dotnet ef database update -p src\Infrastructure -s src\API

