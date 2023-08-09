using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrencibleTRUE.app
{
    public interface ISalaryCalculate 
    {
        decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.2m;
        }
    }
    public class MediumSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.4m;
        }
    }
    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.6m;
        }
    }    
    public class ManagerSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 1.8m;
        }
    }

    internal class SalaryCalculator
    {
        public decimal Calculator(decimal salary,ISalaryCalculate salaryCalculate)
     => salaryCalculate.Calculate(salary);
    }
}
