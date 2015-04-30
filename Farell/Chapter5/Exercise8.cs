using System;

namespace Farrell.Chapter5
{
    public class Exercise8
    {
        private const int DiscountDays = 7;
        private const int DiscountRate = 10;
        private double _price;

        public void CalcDiscount()
        {
            HouseKeeping();
            while (_price!=-1.0)
            {
                DetailLoop();
            }
            
            EndOfJob();
        }

        private void HouseKeeping()
        {
            Console.WriteLine("Please enter price to calculate the discount for 7 days or quit with \'-1\': ");
            _price = Convert.ToInt32(Console.ReadLine());

        }

        private void DetailLoop()
        {
            Console.WriteLine("Your price is: " + _price);

            int daysCounter = 1;
            while (daysCounter <= DiscountDays)
            {
                _price -= _price / DiscountRate;
                Console.WriteLine("new price is: " + _price);
                daysCounter += 1;
            }
            
            Console.WriteLine("You want to continue?" + Environment.NewLine);
            Console.WriteLine("Please enter price to calculate the discount for 7 days or quit with \'-1\': ");
            _price = Convert.ToInt32(Console.ReadLine());
        }

        private void EndOfJob()
        {
            Console.WriteLine("Program has ended");
        }
    }
}