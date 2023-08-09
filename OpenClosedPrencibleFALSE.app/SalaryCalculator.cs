using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrencibleFALSE.app
{
    internal class SalaryCalculator
    {
        public decimal Calculator(decimal salary,SalaryType salaryType)
        {
            decimal newSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 1.2m;
                    break;
                case SalaryType.Medium:
                    newSalary = salary * 1.4m;
                    break;
                case SalaryType.High:
                    newSalary = salary * 1.7m;
                    break;
                default:
                    break;
            }
            return newSalary;
        }
    }

    enum SalaryType
    {
        Low,
        Medium, 
        High
    }
}
