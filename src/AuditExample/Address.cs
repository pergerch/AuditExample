// <copyright file="Address.cs" company="pergerch">
// Copyright (c) pergerch. All rights reserved.
// </copyright>

namespace AuditExample
{
	public class Address
	{
		public Address(string city, string street)
		{
			City = city;
			Street = street;
		}

		public string City { get; private set; }

		public string Street { get; private set; }
	}
}