using System;
using System.Collections.Generic;

namespace EncapsulationLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // 1. Sort Persons by Name and Age
             // ===============================
             
            var lines = 5;
            var persons = new List<Person>(); // skapa en ny lista
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(); // userinput
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person); // added userinput
            }
            persons.OrderBy(p => p.FirstName) // => lambda operator
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString())); // ToString metod call
            */

            // 2. Salary Increase
            // ==================

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus)); persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
