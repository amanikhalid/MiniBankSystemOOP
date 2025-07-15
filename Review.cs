using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Review
    {
        public int AccountNumber { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get; set; }

        public Review(int accNum, string comment)
        {
            AccountNumber = accNum;
            Comment = comment;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm}] Account {AccountNumber}: {Comment}";
        }
    }
}
    

