using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Farrell.Chapter5
{
    public class Exercise6B
    {
        private string customerName;
        private int accountNumber;
        private double balanceDue;
        private double _originalBill;
        private const int MonthCount = 10;

        public void ShowBalanceDue10Month()
        {
            Housekeeping();
            while (accountNumber!=-1)
            {
                DetailLoop();
            }
            
            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("No Interest Credit Company");
            Console.WriteLine("Please enter your account number or quit with \"-1\": ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
        }

        private void DetailLoop()
        {
            Console.WriteLine("Please enter your customer name: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Please enter your balance due: ");
            balanceDue = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Your customer bill for 10 month is: ");
            Console.WriteLine("customer name: {0}, accountNumber: {1} " + Environment.NewLine,customerName, accountNumber);
            //output customerName + accountNumber

            double OriginalBill = balanceDue;

            int i = 1;
            while (i <= MonthCount)
            {
                balanceDue -= OriginalBill / 10;
                Console.WriteLine("Your updated balance due is: {0}", balanceDue);
                i += 1;
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Please enter your account number or quit with \"-1\": ");
            }
        }

        private void EndOfJob()
        {
            Console.WriteLine("Program ended");
        }




    }
}
