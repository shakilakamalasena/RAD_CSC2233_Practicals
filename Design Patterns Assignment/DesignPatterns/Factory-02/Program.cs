using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_02
{
    internal class Program
    {

        public class Person 
        { 
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Person_Factory
        {
            private int currentId = 0;

            public Person Create_Person(string name)
            {
                Person person = new Person()
                {
                    Id = currentId,
                    Name = name
                };

                currentId++;
                return person;
            }
        }

        static void Main(string[] args)
        {
            Person_Factory person_Factory = new Person_Factory();

            Person person1 = person_Factory.Create_Person("Alice");
            Person person2 = person_Factory.Create_Person("Bob");
            Person person3 = person_Factory.Create_Person("Charlie");

            Console.WriteLine($"Person 1: Id = {person1.Id}, Name = {person1.Name}");
            Console.WriteLine($"Person 2: Id = {person2.Id}, Name = {person2.Name}");
            Console.WriteLine($"Person 3: Id = {person3.Id}, Name = {person3.Name}");

            Console.ReadKey();
        }
    }
}
