using System;
namespace Övning_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken stad kommer du ifrån?");
            string stad = Console.ReadLine();
            Console.WriteLine("vad är ditt drömresemål?");
            string resemål = Console.ReadLine();

            Console.WriteLine("Hej " + stad +"sbo. Jag hoppas att du får resa till " + resemål + ".");
            Console.ReadKey();
        }
    }
}
