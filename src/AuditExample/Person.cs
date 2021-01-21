// <copyright file="Person.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using System.Collections.Generic;

	public class Person
	{
		public virtual ICollection<Department> Departments { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }
	}
}