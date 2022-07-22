namespace testingclasses
{
    internal class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age; FirstName = firstName; LastName = lastName;

        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }

}

/*-----------------------------------second class*/


using System;

namespace testingclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections ");
            
            static void UseList(){
                List<Person> people = new List<Person>(){
                    new Person {FirstName = "Greg", LastName = "Student", Age =18 },
                    new Person {FirstName = "Nexus", LastName = "Student", Age =18 },
                    new Person {FirstName = "Joseph", LastName = "Student", Age =18 },
                    new Person {FirstName = "Art", LastName = "Student", Age =18 },
                    new Person {FirstName = "Juan", LastName = "Student", Age =18 }
                };

                Console.WriteLine("Items in list : {0}", people.Count);

                foreach (Person p in people){
                    Console.WriteLine("\n ->Adding new person.");
                }
                    
                    Console.WriteLine("\n ->Adding new person.");
                    people.Insert(2, new Person {FirstName = "JJ", LastName = "Student, Age = 21"});
                    Console.WriteLine("Items in list : {0}", people.Count);

                    Person[] arrayOfPeople = people.ToArray();
                    foreach (Person p in people){
                        Console.WriteLine("First Names: {0}", p.FirstName);
                }
            }

        }

    }
}


