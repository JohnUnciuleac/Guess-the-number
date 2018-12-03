using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numarRandom = random.Next(1, 100);
            int contor = 0;
            int numarUser = 0;
            Console.WriteLine("Care crezi ca e numarul din intervalul 1-100 la care ma gandesc?");

            while (numarUser != numarRandom)
            {
                numarUser = Convert.ToInt32(Console.ReadLine());
               
                if (numarUser < numarRandom)
                {
                    Console.WriteLine("Gresit! Numarul la care ma gandesc este mai mare decat {0}. Incearca din nou ", numarUser);
                    contor++;
                }
                if (numarUser > numarRandom)
                {
                    Console.WriteLine("Gresit! Numarul la care ma gandesc este mai mic decat {0}. Incearca din nou ", numarUser);
                    contor++;
                }
            }
            if (numarUser == numarRandom)
            {
              Console.WriteLine("Felicitari! Ai ghicit numarul din {0} incercari! Acesta era {1}", contor+1,numarRandom);
              Console.ReadLine();
            }
        }
    }
}
