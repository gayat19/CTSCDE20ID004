using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class AccountFactory
    {
        public Account CreateAccounts(string accNum)
        {
            Account account = null;
            if(accNum.StartsWith("0000"))
            {
                account = new SavingsAccount();
                account.Balance = 5000;
                account.AccountNumber = accNum;
                return account;
            }
            else if(accNum.StartsWith("1111"))
            {
                account = new CurrentAccount();
                account.Balance = 10000;
                account.AccountNumber = accNum;
            }
            return account;
        } 

       
    }
}
