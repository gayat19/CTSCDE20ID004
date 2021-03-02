using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    class SavingsAccount : Account
    {
        private string _accountNum;
        private float _balanace;
        public override string AccountNumber { get =>_accountNum; set => _accountNum=value; }
        public override float Balance { get => _balanace; set => _balanace=value; }
        public override string AccountType { get => "Savings Account";  }
    }
    class CurrentAccount : Account
    {
        private string _accountNum;
        private float _balanace;
        public override string AccountNumber { get => _accountNum; set => _accountNum = value; }
        public override float Balance { get => _balanace; set => _balanace = value; }
        public override string AccountType { get => "Current Account";  }
    }
}
