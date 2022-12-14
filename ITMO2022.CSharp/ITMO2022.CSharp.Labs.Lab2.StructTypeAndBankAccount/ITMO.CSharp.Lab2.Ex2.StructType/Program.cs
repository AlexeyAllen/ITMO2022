using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Lab2.Ex2.StructType
{
    public enum AccountType { Checking, Deposit }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;

        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct NUmber {0}", goldAccount.accNo);
            Console.WriteLine("Acc Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);

            Console.ReadKey();
        }
    }
}
