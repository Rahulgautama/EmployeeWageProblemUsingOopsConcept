using System;
using System.Collections.Generic;
using System.Text;

namespace OopsEmployeeWageProblem
{
    class CheckEmployeeAttendance
    {
        public void EmpoyeeAttendacne()
        {
            const int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Empoyee is Present");
            }
            else
            {
                Console.WriteLine("Empoyee is Absent");
            }
        }
    }
}
