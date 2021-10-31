using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    public class Employee
    {
        public Employee(string name, string jobTitle, decimal salary, int seneniority)
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
            Seneniority = seneniority;
        }

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        private int _seneniority;
        public int Seneniority
        {
            get { return _seneniority; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Seneniority level must be in [1..10]");
                }
                _seneniority = value;
            }
        }
        public virtual decimal CalculateYearlySalary()
        {
            return Salary * 12 + SeneniorityBonus; 
        }
        public decimal SeneniorityBonus
        {
            get { return Seneniority * 10m;  }
        }

    }
}
