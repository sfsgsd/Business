# GymManagement

dotnet tool update --global dotnet-ef

dotnet ef migrations add InitialCreate -p src\GymManagement.Infrastructure -s src\GymManagement.Api

dotnet ef database update -p src\GymManagement.Infrastructure -s src\GymManagement.Api

