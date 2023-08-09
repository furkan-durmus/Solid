using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrencibleTRUE_2.app
{
    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.2m;
        }
    }
    public class MediumSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.4m;
        }
    }
    public class HighSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.6m;
        }
    }    
    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.8m;
        }
    }

    internal class SalaryCalculator
    {
        public decimal Calculator(decimal salary,Func<decimal,decimal> calculateDelegate)
     => calculateDelegate(salary);
    }
}
