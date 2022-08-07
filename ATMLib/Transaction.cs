using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
   public  class Transaction
    {

        public decimal TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string CardNumber { get; set; }
    }
}
