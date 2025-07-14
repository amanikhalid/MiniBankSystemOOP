using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string Name { get; private set; }
        public string NationalId { get; private set; }
        public double Balance { get; private set; }
        public string UserType { get; set; }
        public bool IsLocked { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        private string HashedPassword;

    }
}
