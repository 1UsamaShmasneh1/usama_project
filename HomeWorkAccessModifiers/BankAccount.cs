using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAccessModifiers1
{
    class BankAccount
    {
        private double _balance;
        private string _bankName;
        private string _accountNumber;
        public BankAccount(int balance, string bankName, string accountNumber)
        {
            _balance = balance;
            _bankName = bankName;
            _accountNumber = accountNumber;
        }

        public void WithdrawOrDeposit(double amount)
        {
            _balance += amount;
        }
        
        public string GetAccountDetails()
        {
            return $"Account number: {_accountNumber}, Bank name: {_bankName}";
        }
    }
}
