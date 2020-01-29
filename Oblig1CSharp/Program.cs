using System;

namespace Oblig1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine(Person.Informasjon());

            Console.ReadLine();
            //Person.FinnId(Convert.ToInt32(Console.ReadLine()));  // denne metoden skal ta in bruker input og gi personen via id (eks "2" er trykket) 
        }
    }
}
