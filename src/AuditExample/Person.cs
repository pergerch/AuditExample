// <copyright file="Person.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	using System.Collections.Generic;

	public class Person
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Address Address { get; set; }
	}
}