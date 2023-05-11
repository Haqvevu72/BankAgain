using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Worker : Person
    {

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Operation> Operations { get; set; }

        // Parametrized  Constructor 
        public Worker(Guid iD, string? name, string? surname, int age, double salary, DateTime startTime, DateTime endTime, List<Operation> operations) : base(iD, name, surname, age, salary)
        {
            StartTime = startTime;
            EndTime = endTime;
            Operations = operations;
        }

        // Add operation
        public void addOperation(Operation o)
        {
            Operations.Add(o);
        }
    }
}
