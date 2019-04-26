using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EngSoftwareForum.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int AvatarSet { get; set; }

    }
}
