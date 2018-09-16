using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Develop
    {
        static void Main(string[] args)
        {
            Account ac = new Account("qwert1234", 10000, 10000);
            ac.Display();
            ac.Buy(17000);
            ac.Display();
        }
    }

    public class Account
    {
        private string accountName;
        //private int accountBalance;
        //private int creditBalance;
        private int credit;
        private int debit;

        public void Credit(int credit)
        {
            Console.WriteLine("Credit {0} bath", credit);
            // creditBalance += amount;
        }
        public void Debit(int debit)
        {
            //     if (amount > accountBalance)
            // Console.WriteLine("Credit {0} bath", credit);
            //  else
            //    accountBalance -= amount;
            Console.WriteLine("Debit {0} bath", debit);
        }

        public void Buy(int buy)
        {
            if (credit >= buy)
            {
                credit = credit - buy;
            }
            else
            {
                Console.WriteLine("Please select Debit or Credit : [1] Credit, [2] Debit");
                int s = Convert.ToInt16(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        debit = debit + (credit - buy);
                        credit = 0;
                        break;
                    case 2:
                        Console.WriteLine("You");
                        credit = credit + (debit - buy);
                        debit = -debit;
                        break;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Balance: Credit = {1,10:C} , Debit = {2,10:C}", accountName, credit, debit);
        }

        public Account(string accountName, int credit, int debit)
        {
            this.accountName = accountName;
            this.credit = credit;
            this.debit = debit;
            //accountBalance = amount;
        }
    }
}