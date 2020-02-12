using System;
using System.Collections.Generic;
using System.Text;


namespace Oblig1CSharp
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }

        public void Show()
        {
            var death = "";
            var mother = "";
            var father = "";

            if (DeathYear != 0)
            {

                death = Convert.ToString("DeathYear: " + DeathYear);
            }
            if (Mother != null)
            {
                mother = "Mor: Id: " + Convert.ToString(Mother.Id) + " Name: " + Mother.FirstName + " " + Mother.LastName;
            }
            if (Father != null)
            {
                father = "Far: Id: " + Convert.ToString(Father.Id) + " Name: " + Father.FirstName + " " + Father.LastName;
            }
            Console.WriteLine($"Id: {Id} Name: {FirstName} {LastName} BirthYear: {BirthYear} {death}  {mother} {father} ");

        }
        public void Barn(int id, List<Person> liste)
        {
            var count = 0;
            //List<Person> = new List<>
            foreach (var person in liste)
            {

                if (person.Father == liste[id - 1] || person.Mother == liste[id - 1])
                {

                    if (count == 0) Console.WriteLine("Barn:");
                    Console.WriteLine($"Id: {Convert.ToString(person.Id)} Name: {person.FirstName} {person.LastName} BirthYear: {person.BirthYear} ");
                    count++;
                }
            }
        }
    }
}
