using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Client : Person
    {
        public string? LiveAddress { get; set; }
        public string? WorkAddress { get; set; }
        public Credit Credit { get; set; }

        public Client(Guid iD, string? name, string? surname, int age, double salary,string? liveaddress,string? workaddress,Credit credit) : base(iD, name, surname, age, salary)
        {
            LiveAddress = liveaddress;
            WorkAddress = workaddress;
            Credit = credit;
        }

        public override string ToString()
        {
            return base.ToString() + $"Live Address: {LiveAddress}\nWork Address: {WorkAddress}";
        }
    }
}
