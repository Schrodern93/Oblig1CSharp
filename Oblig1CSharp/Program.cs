using System;
using System.Collections.Generic;

namespace Oblig1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // lager en liste av type Person
            List<Person> personListe = new List<Person>();

            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };
            var gunnar = new Person { Id = 9, FirstName = "Gunnar", LastName = "Nordmann"};

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            // legger til personer i lista (personListe)
            personListe.Add(sverreMagnus);
            personListe.Add(ingridAlexandra);
            personListe.Add(haakon);
            personListe.Add(metteMarit);
            personListe.Add(marius);
            personListe.Add(harald);
            personListe.Add(sonja);
            personListe.Add(olav);
            personListe.Add(gunnar);

            Console.WriteLine("Skriv in (hjelp) for hjelpetekst");
            Console.WriteLine("Skriv in (stop) for å stoppe programmet");
            var input = "";
            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input == "hjelp") Program.Hjelp();
                else if (input == "liste") Program.Liste(personListe);
                else if (input == "vis")
                {
                    Console.WriteLine("Hvilken Id vil du vise");
                    var inputId = Convert.ToInt32(Console.ReadLine());
                    Program.Vis(inputId, personListe);
                }
                else Console.WriteLine("Feil kommando");
            }
        }

        private static void Vis(int inputId, List<Person> person)
        {

            person[inputId - 1].Show();
            person[inputId - 1].Barn(inputId, person);
        }

        private static void Liste(List<Person> liste)
        {
            foreach (var personer in liste)
            {
                personer.Show();
            }
        }

        public static void Hjelp()
        {
            Console.WriteLine("Skriv inn (vis) for å vise en bestemt person");
            Console.WriteLine("Skriv inn (liste) for å vise alle personer");
        }



    }
}
