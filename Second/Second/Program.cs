using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Second {

    enum TypPlanety { Merkury, Wenus, Ziemia, Mars, Jowisz, Saturn, Uran, Neptun };

    class Program {
        static void Main(string[] args) {
            //ZgadnijLiczbe();
            WczytajPlanety();
        }


        static void ZgadnijLiczbe() {
            Random random = new Random(); // tworzenie obiektu klasy Random
            int wylosowana = random.Next(0, 100); //losowanie int z zakresu 0 - 100
            int i;
            do {
                Console.WriteLine("Podaj liczbe: "); 
                i = int.Parse(Console.ReadLine());

                if (i < wylosowana)
                    Console.WriteLine("Za mala liczba");
                else if (i > wylosowana)
                    Console.WriteLine("Za duza liczba");
            } while (i != wylosowana);

            Console.WriteLine("Brawo odgadles: {0}", i);
        }


        static void Planety() {
            WczytajPlanety();
        }

        static void WczytajPlanety() {
            TypPlanety planeta;
            Console.WriteLine("Podaj nazwe planety.");
            string nazwaPlanety = Console.ReadLine(); // pobranie i przekonwertowanie do String
            nazwaPlanety = nazwaPlanety.ToLower(); // zmiana liter na male


            //porownanie nazwy z enumem i przypisanie do enuma
            if (nazwaPlanety == "merkury")
                planeta = TypPlanety.Merkury;
            else if (nazwaPlanety == "wenus")
                planeta = TypPlanety.Wenus;
            else if (nazwaPlanety == "ziemia")
                planeta = TypPlanety.Ziemia;
            else if (nazwaPlanety == "mars")
                planeta = TypPlanety.Mars;
            else if (nazwaPlanety == "jowisz")
                planeta = TypPlanety.Jowisz;
            else if (nazwaPlanety == "saturn")
                planeta = TypPlanety.Saturn;
            else if (nazwaPlanety == "uran")
                planeta = TypPlanety.Uran;
            else if (nazwaPlanety == "neptun")
                planeta = TypPlanety.Neptun;
            else { // nie ma takiej planety
                Console.WriteLine("Nie ma takiej planety!");
                return; //przerwa w instrukcji
            }

            WyswietlPlanete(planeta); // wywowanie funkcji WyswietlPlanete z wybrana planeta 
        }

        static void WyswietlPlanete(TypPlanety typPlanety) {
            switch (typPlanety) {//porownanie intniejacych planet i wyswietlenie jej nazwy
                case TypPlanety.Merkury:
                Console.WriteLine("Merkury!");
                break;
                case TypPlanety.Jowisz:
                Console.WriteLine("Jowisz!");
                break;
                case TypPlanety.Mars:
                Console.WriteLine("Mars!");
                break;
                case TypPlanety.Neptun:
                Console.WriteLine("Neptun!");
                break;
                case TypPlanety.Saturn:
                Console.WriteLine("Saturn!");
                break;
                case TypPlanety.Uran:
                Console.WriteLine("Uran!");
                break;
                case TypPlanety.Wenus:
                Console.WriteLine("Wenus!");
                break;
                case TypPlanety.Ziemia:
                Console.WriteLine("Ziemia!");
                break;
            }
        }
    }
}
