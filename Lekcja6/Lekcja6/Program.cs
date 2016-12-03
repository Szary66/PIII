using System;
using Newtonsoft.Json;
using Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Lekcja6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var json = File.ReadAllText ("j.json");
			var jsonArray = JArray.Parse (json);

			var people = jsonArray.Select (x => new Person {
				id = (string)x ["_id"],
				age = (string)x ["age"],
				tags = x["tags"].ToObject<List<string>>()					
			}).ToList ();

			foreach (var i in people) {
				Console.WriteLine (i.id);
				Console.WriteLine (i.age);
				foreach(var k in i.tags)
					Console.WriteLine (k);
			}
		}
	}
}
