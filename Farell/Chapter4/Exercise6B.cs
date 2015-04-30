using System;

namespace Farrell.Chapter4
{
    public class Exercise6B
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
            while (weight != -1)
            {
                DetailLoop();
            }

            Finish();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Barking Lot program");
            InputData();

        }

        private void DetailLoop()
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

            Console.WriteLine("Your customer bill is: {0}", customerBill);
            InputData();
        }

        private void Finish()
        {
            Console.WriteLine("Program ended");
        }

        private void InputData()
        {
#if DEBUG
            Console.WriteLine("Please enter dog's weight or quit with -1");
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
}