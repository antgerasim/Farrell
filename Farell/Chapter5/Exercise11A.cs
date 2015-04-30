using System;

namespace Farrell.Chapter5
{
    public class Exercise11A
    {
        private int _numberOfStars;

        public void DisplayRating()
        {
            Housekeeping();

            while (_numberOfStars != -1)
            {
                DetailLoop();
            }

            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Hollywood Rating Guide");
            Console.WriteLine("Please enter your movie rating or exit with -1: ");
            _numberOfStars = Convert.ToInt32(Console.ReadLine());

        }

        private void DetailLoop()
        {
            while (_numberOfStars < 0 || _numberOfStars > 4)
            {
                Console.WriteLine("Incorrect value" + Environment.NewLine);
                Console.WriteLine("Please enter your movie rating or exit with -1: ");
                _numberOfStars = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your movie rating is: " + _numberOfStars);

            Console.WriteLine("Would you like to continue?");

            Console.WriteLine("Please enter your movie rating or exit with -1: ");
            _numberOfStars = Convert.ToInt32(Console.ReadLine());

        }

        private void EndOfJob()
        {
            Console.WriteLine("Program has been ended");
        }
    }
}