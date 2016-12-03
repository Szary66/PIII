using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Program
  {

    static private int dokladnosc = 2;
    //static private List<Bryla> bryly = new List<Bryla>();
    //static void DodajFiguryDoListy()
    //{
    //  bryly.Add(new Kula());
    //  bryly.Add(new Ostroslup());
    //  bryly.Add(new Prostopadloscian());
    //  bryly.Add(new Stozek());
    //  bryly.Add(new Walec());
    //}

    //pastebin.com/gWpHJCy1
    static void Main(string[] args)
    {
      var bryly = typeof(Bryla)
                  .Assembly.GetTypes()
                  .Where(t => t.IsSubclassOf(typeof(Bryla)) && !t.IsAbstract)
                  .Select(t => (Bryla)Activator.CreateInstance(t)).ToList();
      //  DodajFiguryDoListy();
      do
      {
        Console.WriteLine();
        Console.WriteLine("Bryły");
        Console.WriteLine("Co chcescz policzyć?");
        int i = 1;
        foreach (Bryla obj in bryly)
        {
          Console.WriteLine($"{i}. {obj.Nazwa()}");
          i++;
        }
        Console.WriteLine($"{i}. Koniec");
        var wybor = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if ((wybor > (bryly.Count + 1)) || (wybor < 1))
        {
          Console.WriteLine("Podałeś niewłaściwy numer");

          continue;
        }
        if (wybor == (bryly.Count + 1))
        {
          break;
        }
        Console.WriteLine();
        Console.WriteLine($"{ bryly[wybor - 1].Nazwa()}");
        bryly[wybor - 1].WprowadzDane();
        Console.WriteLine("Podaj Dokładnnośc wyniku");
        int.TryParse(Console.ReadLine(), out dokladnosc);
        Console.WriteLine($"Pole: {bryly[wybor - 1].LiczPole(dokladnosc)}");
        Console.WriteLine($"Objętośc: {bryly[wybor - 1].LiczObjetosc(dokladnosc)}");
        dokladnosc = 2;
      } while (true);
    }
  }
}