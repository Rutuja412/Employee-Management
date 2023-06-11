using System;

namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Management");
            Employee.ComputeEmpWage("Dmart", 20, 2, 10);
            Employee.ComputeEmpWage("Reliance", 10, 4, 20);

        }
    }
}
