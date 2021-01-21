// <copyright file="Department.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using System.Collections.Generic;

	public class Department
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual ICollection<Person> Persons { get; set; }
	}
}