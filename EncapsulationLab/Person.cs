using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLab
{
    class Person
    {
        // privata fält
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


        // Konstruktor
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        // publika properties
        public string FirstName
        {

            get
            {
                return this.firstName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {

            get
            {
                return this.lastName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lastName = value;
            }
        }


        public int Age
        {
            get => this.age; // försöker med (=> lambda operator)


            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }

        public decimal Salary
        {

            get
            {
                return this.salary;
            }

            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollar!");
                }
                this.salary = value;
            }
        }

        /*
        // Override ToString metod
        public override string ToString()
        {
            // ToString(): string - override
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
        */

        internal void IncreaseSalary(decimal percentage)
        {
            if (age < 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary + percentage / 200;
            }
        }



        public override string ToString()
        {
            // ToString(): string - override
            return $"{firstName} {lastName} receives {salary} dollars.";
        }
    }
}
