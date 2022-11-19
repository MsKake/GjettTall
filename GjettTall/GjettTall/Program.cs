using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GjettTall
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int Tall = random.Next(1, 50);
                int Gjett = 0;

                Console.WriteLine("Jeg tenker på et tall fra 1-50.  Kan du gjette hvilket tall jeg tenker på?");

                while (Gjett != Tall)
                {
                    Gjett = Convert.ToInt32(Console.ReadLine());

                    if (Gjett < Tall)
                    {
                        Console.WriteLine("Nei, tallet jeg tenker på er høyere enn " + Gjett);
                    }
                    else if (Gjett> Tall)
                    {
                        Console.WriteLine("Nei, tallet jeg tenker på er lavere enn " + Gjett);
                    }
                }
                Console.WriteLine("Bra jobbet! Svaret var " + Tall);
                Console.ReadLine();
        }
    }
}
