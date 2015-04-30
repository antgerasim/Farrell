using System;

namespace Farrell.Chapter4
{
    public class Exercise6A
    {
        private int age;
        private string breed;
        private int customerBill;
        private string name;
        private int ownerId;
        private int weight;

        public void DisplayCustomerBill()
        {
            Housekeeping();
            Detail();
            Finish();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Barking Lot program");

            InputData();

        }

        private void Detail()
        {
            if (weight < RangeConstants.RANGE_1)
            {
                customerBill = CareFeeConstants.FEE_55;
            }
            else
            {
                if (weight <= RangeConstants.RANGE_2)
                {
                    customerBill = CareFeeConstants.FEE_75;
                }
                else
                {
                    if (weight <= RangeConstants.RANGE_3)
                    {
                        customerBill = CareFeeConstants.FEE_105;
                    }
                    else
                    {
                        customerBill = CareFeeConstants.FEE_125;
                    }
                }
            }

            Console.WriteLine("Your customer bill is: {0}",customerBill);
        }

        private void Finish()
        {
            Console.WriteLine("Program ended");
        }

        private void InputData()
        {
#if DEBUG
            Console.WriteLine("Please enter dog's weight");
            weight = Convert.ToInt32(Console.ReadLine());
#else
            Console.WriteLine("Please enter owner ID: ");
            ownerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter dog's name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter dog's breed: ");
            breed = Console.ReadLine();

            Console.WriteLine("Please enter dog's age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter dog's weight");
            weight = Convert.ToInt32(Console.ReadLine());
            
#endif

        }
    }

    internal static class CareFeeConstants
    {
        internal const int FEE_55 = 55;
        internal const int FEE_75 = 75;
        internal const int FEE_105 = 105;
        internal const int FEE_125 = 125;
    }

    internal static class RangeConstants
    {
        internal const int RANGE_1 = 15;
        internal const int RANGE_2 = 30;
        internal const int RANGE_3 = 80;
    }
}