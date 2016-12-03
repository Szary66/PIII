using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Walec : Bryla
  {
    private double promien { set; get; }
    private double wysokosc { set; get; }
    public override double LiczObjetosc(int dokladnosc)
    {
      return Math.Round((Math.PI * Math.Pow(promien, 2) * wysokosc), dokladnosc);
    }

    public override double LiczPole(int dokladnosc)
    {
      return Math.Round((2* Math.PI * Math.Pow(promien, 2)+2* Math.PI * promien*wysokosc), dokladnosc);
    }

    public override string Nazwa()
    {
      return "Walec";
    }

    public override void WprowadzDane()
    {
      Console.WriteLine("Podaj promień podstawy");
      promien = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Podaj Wysokość");
      wysokosc = Convert.ToDouble(Console.ReadLine());
    }
  }
}
