using System;

namespace Farrell.Chapter5
{
    public class Exercise10
    {
        private const int Buildings = 20;
        private const int AtpUnits = 15;
        private const int Rent = 800;
        private const int Months = 12;

        public void DisplayPaymentCoupon()
        {
            Housekeeping();
            Detail();
            EndOfJob();
        }

        private void Housekeeping() { Console.WriteLine("Mr. Roper's payment coupon printer"); }

        private void Detail()
        {
            int month = 1;
            while (month <= Months)
            {
                int buildingNumber = 1;
                while (buildingNumber <= Buildings)
                {
                    int appartmentNumber = 1;
                    while (appartmentNumber <= AtpUnits)
                    {
                        Console.WriteLine("Month: " + month);
                        Console.WriteLine("Buidling number: " + buildingNumber);
                        Console.WriteLine("Appartment number: " + appartmentNumber);
                        Console.WriteLine("Rent: " + Rent);
                        appartmentNumber += 1;
                    }
                    buildingNumber += 1;
                }
                month += 1;
            }
        }

        private void EndOfJob() { }
    }
}