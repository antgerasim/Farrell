using System;

namespace Farrell.Chapter5
{
    public class Exercise9
    {
        private const int Years = 20;
        private const int QUIT = -1;
        private const int InterestRate = 4;
        private int accountNumber;
        private double balance;
        private string firstName;
        private string lastName;

        public void ShowCompoundInterest()
        {
            Housekeeping();
            while (accountNumber!=QUIT)
            {
                DetailLoop();
            }
            
            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Howell Bank Exercise");
            Console.WriteLine("Please enter your account number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

        }

        private void DetailLoop()
        {
            Console.WriteLine("Please enter your initial Deposit");
            balance = Convert.ToDouble(Console.ReadLine());

            double orginalBalance = balance;

            int yearsCounter = 1;

            while (yearsCounter <= Years)
            {
                //double temp = orginalBalance* InterestRate/100;//Result: 104, 108, 112
                double temp = balance * InterestRate / 100;//Result: 104, 108.16, 112.49, 116.99
                balance += temp;
                Console.WriteLine("Your updated deposit for {0} year is: {1}",  yearsCounter,balance);
                yearsCounter += 1;
            }
        }

        private void EndOfJob()
        {
            Console.WriteLine("Program has been ended");
        }
    }
}