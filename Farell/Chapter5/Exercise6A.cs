﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farrell.Chapter5
{
    public class Exercise6A
    {
        private string customerName;
        private int accountNumber;
        private double balanceDue;
        private double _originalBill;
        private const int MonthCount = 10;

        public void ShowBalanceDue10Month()
        {
            Housekeeping();
            Detail();
            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("No Interest Credit Company");
            Console.WriteLine("Please enter your account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

        }

        private void Detail()
        {
            Console.WriteLine("Please enter your customer name: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Please enter your balance due: ");
            balanceDue = Convert.ToDouble(Console.ReadLine());
            double OriginalBill = balanceDue;

            //output customerName + accountNumber
            int i = 1;
            while (i <=MonthCount)
            {
                balanceDue -= OriginalBill / 10;
                Console.WriteLine("Your updated balance due is: {0}",balanceDue);
                i += 1;
            }
        }

        private void EndOfJob()
        {
            Console.WriteLine("Program ended");
        }

       

       
    }
}
