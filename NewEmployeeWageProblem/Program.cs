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
                        EmployeeWage.Attendence();
                        break;
                    default:
                        Console.WriteLine("Please click error-free option");
                        break;
                }
            }
        }
    }
}