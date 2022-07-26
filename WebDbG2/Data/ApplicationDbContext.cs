﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebDbG2.Areas.Identity;

namespace WebDbG2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Dpto>? Dptos{ get; set; }

        public DbSet<Ciudad>? Ciudades { get; set; }

        public DbSet<Persona>? Personas { get; set; }

    }
}