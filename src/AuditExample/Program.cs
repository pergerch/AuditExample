// <copyright file="Program.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using System.Collections.Generic;
	using Audit.Core;

	public class Program
	{
		public static void Main(string[] args)
		{
			using PersonsContext context = new PersonsContext();
			Configuration.Setup().UseFileLogProvider("audit");

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			context.Departments.Add(new Department()
			{
				Id = 1, Name = "Development", Address = new Address { City = "Vienna", Street = "First Street" },
			});

			context.Persons.Add(new Person()
			{
				Id = 1,
				Name = "Development",
				Addresses = new List<Address> { new Address { City = "Vienna", Street = "First Street" } },
			});

			// ArgumentNullException will be thrown here: Value cannot be null. (Parameter 'key')
			context.SaveChanges();
		}
	}
}