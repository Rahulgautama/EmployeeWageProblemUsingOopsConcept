using System;

namespace OopsEmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program using Oops Concept");

            CalculateEmployeeWage empCalWage = new CalculateEmployeeWage();
            int empWage=empCalWage.CalculateWageFullTimePartTime();
            Console.WriteLine("Employee Wage :" + empWage);

        }
    }
}
