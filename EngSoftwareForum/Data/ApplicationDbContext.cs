using System;
using System.Collections.Generic;
using System.Text;
using EngSoftwareForum.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EngSoftwareForum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Questions> Questions { get; set; }

        public DbSet<Replies> Replies { get; set; }
    }
}
