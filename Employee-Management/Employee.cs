using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management
{
    public class Employee
    {
        public static void EmployeeAttendance()
        {
            int empHrs = 0;
            int empWage = 0;
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Part Time");
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Full Time");

                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empWage);
        }
    }
}
