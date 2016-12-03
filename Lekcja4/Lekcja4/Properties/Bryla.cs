using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  abstract class Bryla
  {
    public abstract double LiczObjetosc(int dokladnosc);
    public abstract double LiczPole(int dokladnosc);
    public abstract string Nazwa();
    public abstract void WprowadzDane();
  }
}
