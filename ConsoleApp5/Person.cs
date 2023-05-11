using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Person
    {

        // Fields of `Person` class
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Parametrized Constructor
        public Person(Guid iD, string? name, string? surname, int age, double salary)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nSalary: {Salary}";
        }
    }
}
