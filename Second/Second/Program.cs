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
            //WczytajPlanety();
            //Wyjatek();

            RownanieKwadratowe(1, 2, 3);
        }

        //zadanie 1 ********************************************************************************
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




        // zadanie 2 ************************************************************************************
        static void Planety() {
            WczytajPlanety();
        }

        static void WczytajPlanety() {
            TypPlanety planeta;
            Console.WriteLine("Podaj nazwe planety.");
            string nazwaPlanety = Console.ReadLine(); // pobranie i przekonwertowanie do String
            nazwaPlanety = nazwaPlanety.ToLower(); // zmiana liter na male


            //porownanie nazwy z enumem i przypisanie do enuma
            try {
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
                    throw new ArgumentOutOfRangeException("Nie ma takiej planety!");
                }

                WyswietlPlanete(planeta); // wywowanie funkcji WyswietlPlanete z wybrana planeta 
            } catch (Exception e) {
                Console.WriteLine($"Wyjatek:  { e.Message}");
            }

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

        //******************************************wyjatek
        static void Wyjatek() {
            try { // wykonanie dzialania
                var d = double.Parse(Console.ReadLine());

                throw new ArgumentNullException();
            } catch (FormatException e) { // obsluga w ranie wystapienia wyjatku
                Console.WriteLine($"Wystapil wyjatel: {e.Message}");
            }

        }

        //*******************************************tablice
        static void Tablice() {
            int size;
            size = 7;
            double[] t = new double[size];

            double[] tab = { 1, 2, 3, 4, 5, 6, 7 };


            double? d = null; //typ? - może przyjmować typ null
        }

        //zadanie 3
        static void RownanieKwadratowe(double a, double b, double c) {
            double delta = b * b - 4 * a * c;

            try {
                if (delta > 0) {
                    Pierwiastki2(delta, a, b);
                } else if (delta == 0) {
                    Pierwiastkek1(delta, a, b);
                } else {
                    throw new ArgumentOutOfRangeException("Nie ma pierwiastkow!");
                }
            } catch (Exception e) {
                Console.WriteLine($"{e.Message}");
            }
        }

        static void Pierwiastki2(double delta, double a, double b) {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }

        static void Pierwiastkek1(double delta, double a, double b) {
            double x0 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x0 = {0}", x0);
        }
    }

    //zadanie domowa srednia arytmetyczna, max, min dla ciagu liczb, pytaj czy uzytkownik chce wczytaj kolejna liczbe - BEZ TABLiC
}
