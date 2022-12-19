using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employeewagecompute");
            const int IS_PRESENT = 1;

            //UC-1 Check employee Present or Not
            Random random = new Random();
            int employeeInput = random.Next(0, 2);

            if (IS_PRESENT == employeeInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            Console.ReadLine();
        }
    }
}
