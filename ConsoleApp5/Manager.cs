using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Manager : Worker,IOrganize
    {
        public Manager(Guid iD, string? name, string? surname, int age, double salary) : base(iD, name, surname, age, salary)
        {
        }

        public void organize() {
            Console.WriteLine("Manager organizing");
        }

        public void calculateSalaries() {
            Console.WriteLine("Manager calculating salaries");
        }
    }
}
