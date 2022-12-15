using System;
namespace NewEmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("*********WelCome To Employee Wage Problem***********");
                Console.WriteLine("Please Click Below options: \n1.EmployeeAttendence\n2.CalculatingEmpWage\n3.AddEmpPartTimeWage\n4.SwitchStatement");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        EmployeeWage employeeWage = new EmployeeWage();
                        employeeWage.Attendence();
                        Console.WriteLine("**************************************************************************************");
                        break;
                    case 2:
                        EmployeeWage employeeWage1 = new EmployeeWage();
                        employeeWage1.CalculatingEmpWage();
                        Console.WriteLine("**************************************************************************************");
                        break;
                    case 3:
                        EmployeeWage employeeWage2 = new EmployeeWage();
                        employeeWage2.AddEmpPartTimeWage();
                        Console.WriteLine("**************************************************************************************");
                        break;
                    case 4:
                        EmployeeWage employeeWage3 = new EmployeeWage();
                        employeeWage3.SwitchStatement();
                        Console.WriteLine("**************************************************************************************");
                        break;
                    default:
                        Console.WriteLine("Please click error-free option");
                        break;
                }
            }
        }
    }
}