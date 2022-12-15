using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeWageProblem
{
    internal class EmployeeWage
    {
        Random random = new Random();
        int IS_Full_Time = 1;
        int IS_Part_Time = 2;
        int Emp_Rate_Per_Hour = 20;
        
        public void Attendence()
        {
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
            int empHrs = 8;
            int empwage = empHrs * Emp_Rate_Per_Hour;
            int empCheck = random.Next(0, 2);
            if(empCheck == this.IS_Full_Time)
            {
                Console.WriteLine($"Employee Wage is :{empwage}");
            }
        }
        public void AddEmpPartTimeWage()
        {
            int empHrs = 0;
            int empCheck = random.Next(0, 3);
            if( empCheck == this.IS_Part_Time)
            {
              empHrs = 4;
            }
            else
            {
              empHrs = 8;
            }
            int empwage = empHrs * this.Emp_Rate_Per_Hour;
            Console.WriteLine($"As we Found the Full Time wage is 160Rupees.......\nIf we Got Pull Time wage 160Rupees That is Full Time wage Suppose If We Got Except 160Rupees then that is Part time wage\n Employee Wage is {empwage}");
        }
    }
}
