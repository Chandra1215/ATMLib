using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    interface IUserDataStore
    {
        bool ValidateUser(User user);

        decimal GetBalanceByCardNumber( string CardNumber);

       List<Transaction> GetTransaction(string CardNumber);

        decimal AddAmount(string CardNumber,decimal Balance);

        decimal WithDrawAmount(string CardNumber, decimal Balance);
         
    }
}
