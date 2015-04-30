using System;

namespace Farrell.Chapter2
{
    public class Exercise7
    {
        private const int FIXCHARGE = 20;
        private const double RATE = 0.02;
        private double checkAmount;
        private double deduct;
        private string MESSAGE = "Program is complete";
        private string name;
        private double serviceCharge; //as result

        public void CalcServiceCharge()
        {
            Housekeeping();
            while (name.Equals("ZZZZ"))
                DetailLoop();
            DetailLoop();
            EndOfJob();

        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter customer name: ");
            name = Console.ReadLine();

        }

        private void DetailLoop()
        {
            Console.WriteLine("Please enter the check amount: ");
            checkAmount = Convert.ToInt32(Console.ReadLine());

            deduct = checkAmount * RATE;
            serviceCharge = FIXCHARGE + deduct;

            Console.WriteLine("Your service chagre is: " + serviceCharge);

            Console.WriteLine("Please enter another name or 'ZZZZ' to quit: ");
            name = Console.ReadLine();
        }

        private void EndOfJob()
        {
            Console.WriteLine(MESSAGE);

        }
    }
}