# GymManagement

dotnet tool update --global dotnet-ef

dotnet ef database update

dotnet ef migrations add InitialCreate -p Persistence -s API

dotnet ef database update -p src\GymManagement.Infrastructure -s src\GymManagement.Api

