using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Ostroslup : Bryla
  {
    private double podstawaA { set; get; }
    private double podstawaB { set; get; }
    private double wysokosc { set; get; }
    public override double LiczObjetosc(int dokladnosc)
    {
      return Math.Round(((podstawaA*podstawaB*wysokosc) / 3), dokladnosc);
    }

    public override double LiczPole(int dokladnosc)
    {
      return Math.Round(((podstawaA * podstawaB) + 2*(podstawaA * (1 / 2) * Math.Sqrt(Math.Pow((podstawaB/2), 2)+Math.Pow(wysokosc,2))) + 2 * (podstawaB * (1 / 2) * Math.Sqrt(Math.Pow((podstawaA / 2), 2) + Math.Pow(wysokosc, 2)))), dokladnosc);
    }

    public override string Nazwa()
    {
      return "Ostrosłup prawidłowy czworoboczny";
    }

    public override void WprowadzDane()
    {
      Console.WriteLine("Podaj pierwszy bok podstawy");
      podstawaA = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Podaj drugi bok podstawy");
      podstawaB = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Podaj Wysokość");
      wysokosc = Convert.ToDouble(Console.ReadLine());
    }
  }
}
