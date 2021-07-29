using System;
using System.Collections.Generic;
using System.Text;

namespace CAssignment1
{
    class Account
    {
        protected int accountNo { get; set; }
        protected float accountBalance { get; set; }
        protected string password { get; set; }
        static string bankName { get; set; }

        internal Account()
        {
            bankName = "XYZ Bank";
        }

        internal Account(int accountNo, float accountBalance, string password)
        {
            this.accountNo = accountNo;
            this.accountBalance = accountBalance;
            this.password = password;

        }
        internal void displayAccount(Account ba)
        {
            Console.WriteLine("AccountNo: {0} || AccountBalance: {1} || password: {2} || BankName :{3}", accountNo, accountBalance, password,Account.bankName);
        }


        static void Main()
        {
            Account bankaccount = new Account(12345, 49000.00f, "nikita@123");
            Account bankaccount1 = new Account();
            bankaccount.displayAccount(bankaccount1);
           // bankaccount1.displayAccount(bankaccount);
        }
    }
}
