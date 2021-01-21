// <copyright file="Program.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using System.Linq;
	using Audit.Core;

	public class Program
	{
		public static void Main(string[] args)
		{
			using PersonsContext context = new PersonsContext();
			Configuration.Setup().UseFileLogProvider("audit");

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			context.Departments.Add(new Department() { Id = 1, Name = "Development" });
			context.Departments.Add(new Department() { Id = 2, Name = "Research" });

			context.SaveChanges();

			context.Persons.Add(new Person() { Id = 1, Name = "Alice", Departments = context.Departments.ToList() });
			context.Persons.Add(new Person() { Id = 2, Name = "Bob", Departments = context.Departments.ToList() });

			context.SaveChanges();
		}
	}
}