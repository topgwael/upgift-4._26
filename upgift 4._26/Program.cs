using System;
namespace Upgift4._26
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            string heltal = Console.ReadLine();




            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                if (siffra != 9)
                    Console.WriteLine(siffra + 1);
                else if (siffra == 9)
                    Console.WriteLine(siffra = 0);

            }
        }
    }
}

