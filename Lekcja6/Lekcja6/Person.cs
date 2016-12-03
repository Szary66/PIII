using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Lekcja6
{
	public class Person{
		public string id;
		public string age;
		public List<string> tags=new List<string>();
	}

	public class Friend
	{
		public string name { get; set; }
		public int id { get; set; }
	}

	public class Name
	{
		public string last { get; set; }
		public string first { get; set; }
	}



	public class RootObject
	{
		public string favoriteFruit { get; set; }
		public string greeting { get; set; }
		public List<Friend> friends { get; set; } = new List<Friend>();
		public List<int> range { get; set; }
		public List<string> tags { get; set; }
		public string longitude { get; set; }
		public string latitude { get; set; }
		public string registered { get; set; }
		public string about { get; set; }
		public string address { get; set; }
		public string phone { get; set; }
		public string email { get; set; }
		public string company { get; set; }
		public Name name { get; set; }
		public string eyeColor { get; set; }
		public int age { get; set; }
		public string picture { get; set; }
		public string balance { get; set; }
		public bool isActive { get; set; }
		public string guid { get; set; }
		public int index { get; set; }
		public string _id { get; set; }
	}
}

