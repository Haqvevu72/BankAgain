using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class CEO : Worker,IOrganize
    {
        public CEO(Guid iD, string? name, string? surname, int age, double salary) : base(iD, name, surname, age, salary)
        {
        }

        public void organize() {
            Console.WriteLine("CEO organizing");
        }

        public void makemarketing() {
            Console.WriteLine("CEO making marketting");
        }
    }
}
