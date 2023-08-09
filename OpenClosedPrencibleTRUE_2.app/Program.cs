using OpenClosedPrencibleTRUE_2.app;

SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low : {salaryCalculator.Calculator(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Medium : {salaryCalculator.Calculator(1000, new MediumSalaryCalculate().Calculate)}");
Console.WriteLine($"High : {salaryCalculator.Calculator(1000, new HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager : {salaryCalculator.Calculator(1000, new ManagerSalaryCalculate().Calculate)}");
Console.WriteLine($"Test : {salaryCalculator.Calculator(1000, s=> { return s * 2; })}");
