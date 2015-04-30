using System;

namespace Farrell.Chapter2
{
    public class Exercise5B
    {
        private const string MESSAGE = "Thanks for using this program";
        private int _profit;
        private int _retailPrice;
        private int _wholesalePrice;

        public void CalcProfit()
        {
            Housekeeping();
            while (_wholesalePrice != 0)
                DetailLoop();

            EndOfJob();

        }

        private void EndOfJob()
        {
            Console.WriteLine(MESSAGE);
        }

        private void DetailLoop()
        {
            Console.WriteLine("Please enter retail price: ");
            _retailPrice = Convert.ToInt32(Console.ReadLine());
            _profit = _retailPrice - _wholesalePrice;
            Console.WriteLine("Your profit is: " + _profit);

            /*in addition to calculating the profit, it prompts the user for and gets the next wholesale price. */
            Console.WriteLine("Please enter another wholesale price or quit with 0 ");
            _wholesalePrice = Convert.ToInt32(Console.ReadLine());
        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter wholesale price: ");
            _wholesalePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}