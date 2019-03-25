using System;
using System.Collections.Generic;

namespace builderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBuilder CreatePerson = new PersonBuilder();
            var NewPerson = CreatePerson.withName("kuku").withAge(21).withCrazy(true).Build();

            var NewPerson2 = new PersonBuilder()
                                .withCrazy(true)
                                .Build();

            var NewPerson3 = new PersonBuilder()
                                .withName("speciel middle Name")
                                .Build();

            List<Person> personliste = new List<Person>();

            personliste.Add(NewPerson);
            personliste.Add(NewPerson2);
            personliste.Add(NewPerson3);

            foreach (var item in personliste)
            {
                System.Console.WriteLine($"Name : {item.Name} - Age : {item.Age} - Crazy : {item.Crazy}");
            }
            
        }
    }
}
