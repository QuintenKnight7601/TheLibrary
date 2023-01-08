﻿using Microsoft.AspNetCore.Identity;

namespace RapidTireEstimates.Areas.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
    }
}
