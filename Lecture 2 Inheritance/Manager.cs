using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    public class Manager : Employee
    {
        public decimal Bonus { get; set; }
        public Manager(string name, string jobTitle, decimal salary, decimal bonus, int seneniority) : base(name, jobTitle, salary, seneniority)
        {
            Bonus = bonus;
        }

        public override decimal CalculateYearlySalary()
        {
            return base.CalculateYearlySalary() + Bonus;
        }
    }
}
