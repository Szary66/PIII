using System;

namespace First {
    class Program {
        static void Main(string[] args) {
            ////cw + podwójny tab = Console.WriteLine();
            //Console.WriteLine("Lekcja {0}",1);
            //Console.WriteLine(@"Lukasz Mlynarski");
            //Console.WriteLine("43-300 Bielsko-Biala");

            ////Wartosci w stringu
            //Console.WriteLine("{0}+{1}={2}", 1,2,1+2);
            //Console.WriteLine($"{3}+{2}={2+3}");

            ////Wyrownanie do prawej
            //Console.WriteLine($"{4,15}");
            ////Console.WriteLine("{wartosc:formatPrecyzja}
            //Console.WriteLine($"{0:f4}+{1:f4}");

            //Console.WriteLine("{0:C2}", 1.52);

            ////Duze litery
            //Console.WriteLine("Ala Ma Kota".ToLower());
            ////Male litery
            //Console.WriteLine("Ala ma kota".ToUpper());

            ////zwrot indexu podanego znamu w k ciagu
            //Console.WriteLine("Ala ma kota".IndexOf("k"));

            //object k = new int [10];
            //Console.WriteLine(k.ToString());

            //double delta = 10;
            //Console.WriteLine(delta.Equals(10));// porownianie czy ardument jest rowny zmiennej
            //Console.WriteLine(delta.GetType()); // wzrot typu
            //Console.WriteLine(delta.GetHashCode()); // wzrot id danego typu

            //Console.WriteLine(double.MinValue); // najmniejsza liczba z typu
            //Console.WriteLine(double.NaN); // nie liczba
            //Console.WriteLine(double.PositiveInfinity); // + niespokczonosc
            //Console.WriteLine(double.NegativeInfinity); // - niesponczonosc
            //Console.WriteLine(double.Parse("1,532")); // rzutowanie ze stringa na double 


            //double d;
            //double.TryParse("aaa", out d); // sprobowanie dopasowania bez wyrzucania wyjatku
            //Console.WriteLine(d);

            //var f = 5.0f; // var dowolny typ

            //Console.Write("Podaj liczbe: ");
            //double s = double.Parse(Console.ReadLine()); // pobranie napisu z klawiatury i przekonwertowanie na double

            //Console.WriteLine(Convert.ToDouble(true));



            //Program sprawdzajacy przejscie przez cwiartki lini na podstawi wspolczynnikow a i b
            //double a, b;

            //Console.WriteLine("Podaj a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj b: ");
            //b = double.Parse(Console.ReadLine());


            //if (a < 0) {
            //    Console.Write("Przechodzi przez 1, 4,");

            //    if (b > 0) {
            //        Console.WriteLine(" 2 ");
            //    } else if (b < 0) {
            //        Console.WriteLine(" 3 ");
            //    }

            //    Console.WriteLine("cwiartke");
            //} else if (a > 0) {
            //    Console.WriteLine("Przechodzi przez 2, 3, ");
            //    if (b > 0) {
            //        Console.WriteLine(" 1 ");
            //    } else if (b < 0)
            //        Console.WriteLine(" 4 ");

            //    Console.WriteLine("cwiartke");
            //} else {
            //    if (b > 0) {
            //        Console.WriteLine("Przechodzi przez 2, 1 cwiartke");
            //    } else if (b < 0) {
            //        Console.WriteLine("Przechodzi przez 3 i 4 cwiartke");
            //    } else
            //        Console.WriteLine("Nie przechodzi przez nic.");
            //}
            // KONIEC ZADANIA

            //Zadanie sprawdzania cisnienia


            int skurcz, rozkurcz;

            Console.WriteLine("Podaj cisnienie skorczowe: ");
            skurcz = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            rozkurcz = int.Parse(Console.ReadLine());

            Console.Write("Cisnienie skorczowe: ");
            if (skurcz < 120) {//optymalne
                Console.WriteLine("Optymalne");
            } else if (120>skurcz && skurcz > 129 ) {//prawidlowe
                Console.WriteLine("Prawidlowe");
            } else if (130> skurcz && skurcz >139) {//wysokie prawidlowe
                Console.WriteLine("Wysokie prawidlowe");
            } else if (140> skurcz && skurcz >159) {//nadcisnienie lagodne
                Console.WriteLine("Nadcisnienie lagodne");
            } else if (160 > skurcz && skurcz > 179) {//nadcisnienie umiarkowane
                Console.WriteLine("Nadcisnienie umiarkowane");
            } else  { // nadciwnienie ciezkie
                Console.WriteLine("Nadcisnienie ciezkie");
            }


            if (rozkurcz < 80) {//optymalne
                Console.WriteLine("Optymalne");
            } else if (81  > rozkurcz && rozkurcz > 84) {//prawidlowe
                Console.WriteLine("Prawidlowe");
            } else if (95 > rozkurcz && rozkurcz > 90) {//wysokie prawidlowe
                Console.WriteLine("Wysokie prawidlowe");
            } else if (90 > rozkurcz && rozkurcz > 100) {//nadcisnienie lagodne
                Console.WriteLine("Nadcisnienie lagodne");
            } else if (160 > rozkurcz && rozkurcz > 110) {//nadcisnienie umiarkowane
                Console.WriteLine("Nadcisnienie umiarkowane");
            } else { // nadciwnienie ciezkie
                Console.WriteLine("Nadcisnienie ciezkie");
            }
            
        }

        int cSkorczowe(int skurcz) {
            if (skurcz < 120) {//optymalne
                Console.WriteLine("Optymalne");
                return 0;
            } else if (120 > skurcz && skurcz > 129) {//prawidlowe
                Console.WriteLine("Prawidlowe");
                return 1;
            } else if (130 > skurcz && skurcz > 139) {//wysokie prawidlowe
                Console.WriteLine("Wysokie prawidlowe");
                return 2;
            } else if (140 > skurcz && skurcz > 159) {//nadcisnienie lagodne
                Console.WriteLine("Nadcisnienie lagodne");
                return 3;
            } else if (160 > skurcz && skurcz > 179) {//nadcisnienie umiarkowane
                Console.WriteLine("Nadcisnienie umiarkowane");
                return 4;
            } else { // nadciwnienie ciezkie
                Console.WriteLine("Nadcisnienie ciezkie");
                return 5;
            }
        }

        int cRozkurcz(int rozkurcz) {

        }
    }
}
