using OpenClosedPrencibleTRUE.app;

SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low : {salaryCalculator.Calculator(1000,new LowSalaryCalculate())}");
Console.WriteLine($"Medium : {salaryCalculator.Calculator(1000,new MediumSalaryCalculate())}");
Console.WriteLine($"High : {salaryCalculator.Calculator(1000,new HighSalaryCalculate())}");
Console.WriteLine($"Manager : {salaryCalculator.Calculator(1000,new ManagerSalaryCalculate())}");
