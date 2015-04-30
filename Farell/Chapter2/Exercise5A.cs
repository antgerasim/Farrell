using System;

namespace Farrell.Chapter2
{
    public class Exercise5A
    {
        private const string MESSAGE = "Thanks for using this program";
        private int _profit;
        private int _retailPrice;
        private int _wholesalePrice;

        public void CalcProfit()
        {
            Housekeeping();
            Detail();
            EndOfJob();

        }

        private void EndOfJob()
        {
            Console.WriteLine(MESSAGE);
        }

        private void Detail()
        {
            Console.WriteLine("Please enter retail price: ");
            _retailPrice = Convert.ToInt32(Console.ReadLine());
            _profit = _retailPrice - _wholesalePrice;
            Console.WriteLine("Your profit is: " + _profit);
        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter wholesale price: ");
            _wholesalePrice = Convert.ToInt32(Console.ReadLine());

        }
    }
}