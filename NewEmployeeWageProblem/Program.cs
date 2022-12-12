using System;
namespace NewEmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("WelCome To Employee Wage Problem");
                Console.WriteLine("Please Click Below options: \n1.EmployeeAttendence");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        EmployeeWage employeeWage = new EmployeeWage();
                        employeeWage.Attendence();
                        break;
                    case 2:
                        EmployeeWage employeeWage1 = new EmployeeWage();
                        employeeWage1.CalculatingEmpWage();
                        break;
                    default:
                        Console.WriteLine("Please click error-free option");
                        break;
                }
            }
        }
    }
}