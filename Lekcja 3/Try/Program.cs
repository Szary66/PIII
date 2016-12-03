using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja4
{
    class Program
    {
        static void Main(string[] args)
        {
//Zadanie1();
//Zadanie2();
//Zadanie3();
            Struktury();
        }

        static void Wprowadzenie()
        {
            double? b = null;
            Console.WriteLine("hallo world!");
            Console.WriteLine("hallo 2 world'y!");

            int size = 10;
            double[] tab1 = new double[size];
            double[] tab2 = new double[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            double[] tab3 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            int i1 = tab1.GetLength(0);
            int i2 = tab1.Length;
        }

//zadanie 1
//napisac tablice jednowym. z liczbami losowymi calkowitymi
//przekazac rozmiar tablicy min oraz max
//funkcja ma zwracać tablice
// funkcja wyswietlajaca elementy tablicy jednowym.
        static Random r = new Random();

        static void Zadanie1()
        {
            int[] tab = null;
            Losowanie(ref tab, 10, 0, 100);
            WyswietlTablice(tab);
//WyswietlTablice(Losowanie(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        static int[] Losowanie(int n, int min, int max)
        {
            int[] tab = new int[n];
            for (int i = 0; i < n; ++i)
            {
                tab[i] = r.Next(min, max);
            }

            return tab;
        }

        static void Losowanie(ref int[] tab, int n, int min, int max)
        {
            tab = Losowanie(n, min, max);
        }

        static void WyswietlTablice(int[] tab)
        {
            foreach (var i in tab)
                Console.Write($"{i}, ");
            Console.WriteLine();
        }

//Zadanie 2 oblicz iloczyn skalarny 2 tablic
//jesli rozmiary sa rozne trzeba ciepnac wyjatek
//sortujaca tablica

        enum Kierunek
        {
            Rosnacy,
            Malejacy
        }


        static int IloczynSkalarny(int[] t1, int[] t2)
        {
            int t3 = 0;

            try
            {
                if (t1.Length != t2.Length)
                    throw new Exception("Tablice sa niejednowymiarowe");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < t1.Length; ++i)
            {
                t3 = t1[i] * t2[i];
            }

            return t3;
        }

        static void SortUp(int[] tab)
        {
            bool k;
            int j = 1;
            do
            {
                k = false;
                for (int i = 0; i < tab.Length - j; ++i)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int l = tab[i + 1];
                        tab[i + 1] = tab[i];
                        tab[i] = l;
                        k = true;
                    }
                }
                ++j;
            } while (k);
            Console.WriteLine(j);
        }

        static void SortDown(int[] tab)
        {
            bool k;
            int j = 1;
            do
            {
                k = false;
                for (int i = 0; i < tab.Length - j; ++i)
                {
                    if (tab[i] < tab[i + 1])
                    {
                        int l = tab[i + 1];
                        tab[i + 1] = tab[i];
                        tab[i] = l;
                        k = true;
                    }
                }
                ++j;
            } while (k);
            Console.WriteLine(j);
        }

        static void Sort(int[] tab, Kierunek kierunek)
        {
            switch (kierunek)
            {
                case Kierunek.Rosnacy:
                    SortUp(tab);
                    break;
                case Kierunek.Malejacy:
                    SortDown(tab);
                    break;
                default:
                    break;
            }
        }

        static void Zadanie2()
        {
            int[] t1 = Losowanie(3, 0, 10);
            int[] t2 = Losowanie(10, 0, 10);

            WyswietlTablice(t1);
            WyswietlTablice(t2);
//Console.WriteLine(IloczynSkalarny(t1, t2));
            Console.WriteLine();
            Console.WriteLine();

            Sort(t2, Kierunek.Malejacy);

            WyswietlTablice(t2);
        }

//Zadanie 3
//Mnożenie Macierzy

        static void Zadanie3()
        {
            int[,] macierz1 = new int[,] {{1, 2, 3}, {1, 1, 2}};
            int[,] macierz2 = new int[,] {{1, 2}, {2, 2}, {3, 3}};

            var t = MnozenieMacierzy(macierz1, macierz2);

            WyswietlMacierz(t);
        }


        static void WyswietlMacierz(int[,] macierz)
        {
            for (int i = 0; i < macierz.GetLength(0); ++i)
            {
                for (int j = 0; j < macierz.GetLength(1); ++j)
                {
                    Console.Write($"{macierz[i, j]}, ");
                }
                Console.WriteLine();
            }
        }



        static int[,] MnozenieMacierzy(int[,] t1, int[,] t2)
        {
            int[,] t3 = new int[t1.GetLength(1), t2.GetLength(0)];
            try
            {
                if (t1.GetLength(1) != t2.GetLength(0))
                    throw new Exception("Zle wymiary");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < t1.GetLength(0); ++i)
            {
                for (int j = 0; j < t2.GetLength(1); ++j)
                {
                    int wyn = 0;
                    for (int k = 0; k < t1.GetLength(1); ++k)
                    {
                        wyn += t1[i, k] * t2[k, j];
                    }
                    t3[i, j] = wyn;
                }
            }


            return t3;
        }

        static void Struktury()
        {
            Osoba kierownik = new Osoba();
            kierownik.imie = "Jak";
            kierownik.nazwisko = "Kowalski";
            kierownik.wiek = 46;

            Osoba inna = new Osoba(50) {imie = "Adam", nazwisko = "Wanek"};
        }
    }

    struct Osoba
    {
        public Osoba(int wiek)
        {
            imie = "Jan";
            nazwisko = "Kowalski";
            this.wiek = wiek;
        }

        public string imie;
        public string nazwisko;
        public int wiek;


        public Osoba Klonuj()
        {
            return (Osoba) this.MemberwiseClone();
        }
    }
}