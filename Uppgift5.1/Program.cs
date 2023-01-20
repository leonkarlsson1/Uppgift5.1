using System;

namespace Uppgift_5._1
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur många meningar vill du skriva in?");
            int antal=int.Parse(Console.ReadLine());
            string[] meningar = new string[antal];

            for(int i= 0; i < antal; i++)
            {
                Console.WriteLine("skriv in en mening");
                meningar[i] = Console.ReadLine();
            }
            Console.WriteLine("här är de menigarna du skrev");
            for(int i=0; i < antal; i++)
            {
                Console.WriteLine($"\n{meningar[i]}");
            }
        }
    }
}
