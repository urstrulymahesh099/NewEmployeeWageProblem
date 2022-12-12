using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeWageProblem
{
    internal class EmployeeWage
    {
        int IS_Full_Time = 1;
        public void Attendence()
        {
            Random random = new Random();
            int Emp=random.Next(0,2);
            if(Emp== this.IS_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void CalculatingEmpWage()
        {
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 8;
            int empwage = empHrs * Emp_Rate_Per_Hour;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == this.IS_Full_Time)
            {
                Console.WriteLine($"Employee Wage is :{empwage}");
            }
        }
    }
}
