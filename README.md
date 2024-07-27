# GymManagement

dotnet tool update --global dotnet-ef

dotnet ef database update

dotnet ef migrations add InitialCreate -p Persistence -s API

dotnet ef database update -p .\src\Business.Persistence -s src\Business.API

