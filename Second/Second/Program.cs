using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second {
    class Program {
        static void Main(string[] args) {
            ZgadnijLiczbe();
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
    }
}
