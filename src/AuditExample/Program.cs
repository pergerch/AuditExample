// <copyright file="Program.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
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

			// ArgumentNullException will be thrown here: Value cannot be null. (Parameter 'name')
			context.SaveChanges();
		}
	}
}