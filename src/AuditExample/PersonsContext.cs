// <copyright file="PersonsContext.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using Audit.EntityFramework;
	using Microsoft.EntityFrameworkCore;

	public class PersonsContext : AuditDbContext
	{
		public DbSet<Department> Departments { get; set; }

		public DbSet<Person> Persons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=database.db").UseLazyLoadingProxies();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>().HasMany<Department>(x => x.Departments).WithMany(x => x.Persons);
		}
	}
}