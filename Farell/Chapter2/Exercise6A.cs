using System;

namespace Farrell.Chapter2
{
    public class Exercise6A
    {
        private const string MESSAGE = "End of Job";
        private const double POUND_IN_GRAMS = 453.59;
        private const double INCH_IN_CM = 2.54;
        private double gownSize;
        private double heightCm;
        private int heightInches;
        private double weightGrams;
        private int weightPounds;

        public void GetGownSize()
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
            Console.WriteLine("Please enter weight in pounds: ");
            weightPounds = Convert.ToInt32(Console.ReadLine());

            weightGrams = weightPounds * POUND_IN_GRAMS;
            heightCm = heightInches * INCH_IN_CM;
            gownSize = heightCm + (weightGrams / 3);

            Console.WriteLine("Your gownsize is: " + gownSize);
        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter height in inches: ");
            heightInches = Convert.ToInt32(Console.ReadLine());
        }
    }
}