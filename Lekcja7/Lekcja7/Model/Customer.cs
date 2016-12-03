using System;
using System.Collections.Generic;

namespace Lekcja7
{
	public class Customer
	{
		public Customer ()
		{
		}

		public string Id{get;set;}
		public string Name{get;set;}
		public string Addres{get;set;}
		public string City{get;set;}
		public string PostalCode{get;set;}
		public string Country{get;set;}
		public string Phone{get;set;}
		public string Fax{get;set;}
		public IEnumerable<Order> Orders;
	}
}

