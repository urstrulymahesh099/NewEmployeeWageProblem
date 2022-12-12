using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeWageProblem
{
    internal class EmployeeWage
    {
        public static void Attendence()
        {
            int IS_Full_Time = 1;
            Random random = new Random();
            int Emp=random.Next(0,2);
            if(Emp== IS_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
