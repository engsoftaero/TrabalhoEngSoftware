using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EngSoftwareForum.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
