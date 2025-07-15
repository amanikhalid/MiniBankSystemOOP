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

        public Transaction(string type, double amount, double balanceAfter)
        {
            Type = type;
            Amount = amount;
            BalanceAfter = balanceAfter;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm} - {Type} {Amount:F2} OMR | Balance: {BalanceAfter:F2}";
        }
    }


}
