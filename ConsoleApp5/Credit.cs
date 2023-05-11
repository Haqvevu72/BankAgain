using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Credit
    {

        public Guid ID { get; set; }
        public double Amount { get; set; }
        public int Percent { get; set; }
        public int Month { get; set; }

        public Credit(Guid iD, double amount, int percent, int month)
        {
            ID = iD;
            Amount = amount;
            Percent = percent;
            Month = month;
        }


        public override string ToString()
        {
            return $"ID:{ID}\nAmount: {Amount}\nPercent: {Percent}\nMotnh: {Month}";
        }
    }
}
