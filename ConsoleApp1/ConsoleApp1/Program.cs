using System;

namespace Programmering
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Talet = new Random();
            int talet = Talet.Next(100);

            Boolean vunnit = false;

            while (vunnit == false)
            {
                Console.WriteLine("Gissa ett tal emellan 1-100");
                string Gissning = Console.ReadLine();
                int.TryParse(Gissning, out int gissning);


                if (gissning == talet)
                {
                    vunnit = true;
                    Console.WriteLine("Rätt");
                }

                else if (gissning > talet)
                {
                    Console.WriteLine("Mindre!");


                }

                else if (gissning < talet)
                {
                    Console.WriteLine("Större!");
                }

            }




        }
    }
}
