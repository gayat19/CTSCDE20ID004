using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDesignPatterns
{
    abstract class Account
    {
        public abstract string AccountType { get;  }
        public abstract string AccountNumber { get; set; }
        public abstract float Balance { get; set; }
    }
}
