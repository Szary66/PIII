using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Prostopadloscian : Bryla
  {
    private double podstawaA { set; get; }
    private double podstawaB { set; get; }
    private double wysokosc { set; get; }
    public override double LiczObjetosc(int dokladnosc)
    {
      return Math.Round((podstawaA * podstawaB * wysokosc), dokladnosc);
    }

    public override double LiczPole(int dokladnosc)
    {
      return Math.Round((2 * podstawaA * podstawaB + 2 * podstawaA * wysokosc + 2 * podstawaB * wysokosc), dokladnosc);
    }

    public override string Nazwa()
    {
      return "Prostopadłościan";
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
