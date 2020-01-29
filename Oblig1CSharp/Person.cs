using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1CSharp
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public int BirthYear { get; private set; }
        public string LastName { get; private set; }

        public static object Informasjon()
        {

            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };



            //sverreMagnus.Father = haakon;
            //sverreMagnus.Mother = metteMarit;
            //ingridAlexandra.Father = haakon;
            //ingridAlexandra.Mother = metteMarit;
            //marius.Mother = metteMarit;
            //haakon.Father = harald;
            //haakon.Mother = sonja;
            //harald.Father = olav;

            string liste = Convert.ToString(sverreMagnus);
            Console.WriteLine(liste);
            return liste;
        }
        public static int FinnId(int id)
        {

            return id;
        }
        public static string NyPerson(int Id1, string FirstName1, string LastName1, int BirthYear1)
        {
            Console.WriteLine("Skriv inn id: ");
            Id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn fornavn: ");
            FirstName1 = Console.ReadLine();
            Console.WriteLine("Skriv inn etternavn: ");
            LastName1 = Console.ReadLine();
            Console.WriteLine("Skriv inn fødselsdag: ");
            BirthYear1 = Convert.ToInt32(Console.ReadLine());
            var NewPerson = new Person { Id = Id1, FirstName = FirstName1, LastName = LastName1, BirthYear = BirthYear1 };

            return Convert.ToString(NewPerson);
        }
    }
}
