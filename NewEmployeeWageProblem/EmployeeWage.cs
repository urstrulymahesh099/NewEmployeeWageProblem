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
        int Is_Part_Time = 2;
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
            if( empCheck == this.Is_Part_Time)
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
        public void SwitchStatement()

       {
 
            int empHrs;
            int empWage;
            Console.WriteLine("click options\n1.IS_Full_Time=160\n2.Is_Part_Time=80");
            int empcheck=random.Next(0, 3);
            switch(empcheck)
            {
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            int empwage = empHrs * this.Emp_Rate_Per_Hour;
            Console.WriteLine("Results Of Employee Wage :"+ empwage);  
            
        }
        public void CalculatiingMothlyWage()
        {

            int empHrs=0;
            int empWage=0;
            int totalEmpWage;
            int Emp_Rate_Per_Hour = 20;
            int NumofdaysWorking = 2;
            int TotalEmpWage = 0;
            Console.WriteLine("click options\n1.IS_Full_Time=160\n2.Is_Part_Time=80");
            for (int day = 0; day < NumofdaysWorking; day++)
            {
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWage = empHrs *Emp_Rate_Per_Hour;
                TotalEmpWage += empWage;
                Console.WriteLine("Results Of Employee Wage :" + empWage);
            }
            Console.WriteLine("Total Emp Wage :"+TotalEmpWage);
        }
    }
}
