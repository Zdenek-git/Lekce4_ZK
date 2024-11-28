using System;
using System.Net.NetworkInformation;

namespace Lekce4_ZK
{
    internal class Program
    {
        static void Main(string[] args)

        {   //32 bit
            int vekZd = 25;
            
            // 64 bit
            long dlouhy = 1234567890;

            float maledesetinne = 1.2f;

            double velkedestinne = 24.202351535626;

            decimal presne_desetinne = (decimal) 1.999652525324864864115645;

            char znak = 'a';

            string retezec = "Ahoj Z";

            bool pravda = true;
            bool nepravda = false;

            var promenna = 1;

            int cenaMleka = 100;
            int cenaMasla = 50;

            int suma = cenaMasla + cenaMleka;

            string vysledek = "Vysledek je: " + suma;

            Console.WriteLine(vysledek);

            int cenaZmrzliny = 10;

            suma = suma + cenaZmrzliny;

            string zmrzlina = "Po pridani zmrzky: ";

            Console.WriteLine(zmrzlina + suma);

            int cenaKafe = 20;
            double cenaJidla = 100;

            double deleni = cenaKafe / cenaJidla;

            Console.WriteLine("Po deleni: " + deleni);

            string uzivatelzadal = Console.ReadLine();

            Console.WriteLine("Uzivatel mi zadal: " + uzivatelzadal);

        }
    }
}
