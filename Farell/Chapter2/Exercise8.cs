using System;
using System.Runtime.InteropServices;

namespace Farrell.Chapter2
{
    public class Exercise8
    {
        private string MESSAGE = "End of job";
        private int salary;
        private double rate;
        private string name;
        private double raise;
        private double result;

        public void CalcEmployeeSalary()
        {
            Housekeeping();
            while (!name.Equals("XXX"))
            {
                DetailLoop();
            }
            
            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter employee name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter current salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the increase in %: ");
            rate = Convert.ToDouble(Console.ReadLine());
            
        }

        private void DetailLoop()
        {
            raise = salary * rate;
            result = salary + raise;

            Console.WriteLine("New salary is: " + result);
            Console.WriteLine("Please enter new name or quit with 'XXX' ");
            name = Console.ReadLine();
        }
        private void EndOfJob()
        {
            Console.WriteLine(MESSAGE);
        }


    }
}