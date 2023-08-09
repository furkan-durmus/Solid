using OpenClosedPrencibleFALSE.app;

SalaryCalculator salaryCalculator = new SalaryCalculator();
Console.WriteLine($"Low : {salaryCalculator.Calculator(1000,SalaryType.Low)}");
Console.WriteLine($"Medium : {salaryCalculator.Calculator(1000,SalaryType.Medium)}");
Console.WriteLine($"High : {salaryCalculator.Calculator(1000,SalaryType.High)}");