using Business.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Business.Infrastructure;

public class BusinessContext : IdentityDbContext<AppUser>
{
    public DbSet<Appointment> Appointments { get; set; } = null!;

    public BusinessContext(DbContextOptions<BusinessContext> options) : base(options)
    {
        
    }

    public async Task CommitChangesAsync() 
    {
        await SaveChangesAsync();
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
