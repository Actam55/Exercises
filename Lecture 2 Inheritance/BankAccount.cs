using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    class BankAccount
    {
        private decimal _balance;
        private double _borrowingRate;
        private double _savingsRate;

        public BankAccount(decimal balance, double borrowingRate, double savingsRate)
        {
            Balance = balance;
            BorrowingRate = borrowingRate;
            SavingsRate = savingsRate;
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance += value;
            }
        }
        public double BorrowingRate
        {
            get
            {
                return _borrowingRate;
            }
            set
            {
                if (value < 6) throw new ArgumentException(" borrowing rate has to be at least 6 % ");
                _borrowingRate = value;
            }
        }
        public double SavingsRate
        {
            get
            {
                return _savingsRate;
            }
            set
            {
                if (value < 6) throw new ArgumentException(" borrowing rate has to be at least 6 % ");
                _savingsRate = value;
            }
        }

        public void Deposit(decimal value)
        {
            if (value < 0)
            {
                new Exception("Can't deposit negative amount");
            }
            if (Balance + value > 250000)
            {
                throw new Exception("Value can't exeed 250.000$");
            }
            Balance = +value;
        }

        public decimal Withdraw(decimal value)
        {
            if (value < 0)
            {
                throw new Exception("Can't withdraw negative amount");
            }
            if (Balance - value < -100000)
            {
                new Exception("Value can't be less than 100.000$");
            }
            Balance -= value;
            return value;
        }

        public void ChargeInterest()
        {
            if (Balance < 100000m)
            {
                Balance -= Balance * 0.01m;
            }
            else
            {
                Balance -= Balance * 0.03m;
            }
        }
    }
}
