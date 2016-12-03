using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Kula : Bryla
  {
    private double promien{ get; set; }
    public override double LiczObjetosc(int dokladnosc)
    {
      return Math.Round(((4 / 3f) * Math.PI * Math.Pow(promien, 3)), dokladnosc);
    }

    public override double LiczPole(int dokladnosc)
    {
      return Math.Round((4 * Math.PI * Math.Pow(promien, 2)), dokladnosc);
    }

    public override string Nazwa()
    {
      return "Kula";
    }

    public override void WprowadzDane()
    {
      Console.WriteLine("Podaj promień kuli");
      promien = Convert.ToDouble(Console.ReadLine());
    }
  }
}
