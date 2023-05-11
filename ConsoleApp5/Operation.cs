using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Operation
    {
        public Guid ID { get; set; }
        public string? ProcessName { get; set; }
        public DateTime OperationTime { get; set; }

        public Operation(Guid iD, string? processName, DateTime operationTime)
        {
            ID = iD;
            ProcessName = processName;
            OperationTime = operationTime;
        }
    }
}
