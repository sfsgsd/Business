﻿using Microsoft.AspNetCore.Identity;

namespace Business.Domain.Entities;

public class AppUser : IdentityUser
{
    public string DisplayName { get; set; }
}
