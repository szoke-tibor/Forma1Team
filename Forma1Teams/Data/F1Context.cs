﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forma1Teams.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Forma1Teams.Data
{
    public class F1Context : IdentityDbContext<IdentityUser>
	{
        public F1Context (DbContextOptions<F1Context> options) : base(options) {}

        public DbSet<Forma1Teams.Models.Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Team>().ToTable("Team");
		}
	}
}