using System;
using System.Collections.Generic;
using System.Text;

namespace OopsEmployeeWageProblem
{
    class CalculateEmployeeWageFullTime
    {
        public void CalculateEmployeeWage()
        {
            int EMP_RAT_PER_HOUR = 20;
            int IS_FULL_TIME = 1;
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * EMP_RAT_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
