using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(BusinessContext context, UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any() && !context.Appointments.Any())
        {
            var users = new List<AppUser> { 
                new AppUser
                {
                    DisplayName = "Bob",
                    UserName = "bob",
                    Email = "bob@test.com"
                }
            };

            foreach (var user in users) { 
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }

            var appointments = new List<Appointment> {
                new Appointment {
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddHours(1),
                },
                new Appointment {
                    StartTime = DateTime.Now.AddHours(1),
                    EndTime = DateTime.Now.AddHours(2),
                }
            };

            await context.Appointments.AddRangeAsync(appointments);
            await context.SaveChangesAsync();

        }
    }

}
