using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib
{
    interface IUserData
    {
        bool ValidateUser(UserInfo user);

        decimal GetBalanceByCardNumber( string CardNumber);

       List<TransactionInfo> GetTransaction(string CardNumber);

        decimal AddAmount(string CardNumber,decimal Balance);

        decimal WithDrawAmount(string CardNumber, decimal Balance);
         
    }
}
