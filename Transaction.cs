using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Transaction
    {
        public string Type { get; set; } 
        public double Amount { get; set; } 
        public double BalanceAfter { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
