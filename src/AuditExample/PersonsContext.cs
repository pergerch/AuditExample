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
			optionsBuilder.UseInMemoryDatabase("testing-db").UseLazyLoadingProxies();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>().OwnsMany(x => x.Addresses);
			modelBuilder.Entity<Department>().OwnsOne(x => x.Address);
		}
	}
}