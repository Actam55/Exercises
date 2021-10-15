using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class bankAccount
    {
        private int Balance;
        public int Balance_
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public bankAccount(int balance)
        {
            if(balance < 0)
            {
                throw new InsufficientFundsException("U poor now");
            }
            Balance = balance;

        }

        public void withdraw(int value)
        {
            if(Balance - value < 0)
            {
                throw new InsufficientFundsException("U too poor to do that right now");
            }
            Balance -= value;
        }
        public void deposit(int value)
        {
            Balance += value;
        }
    }
}
