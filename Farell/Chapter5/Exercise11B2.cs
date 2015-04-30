using System;

namespace Farrell.Chapter5
{
    public class Exercise11B2
    {
        private int INPUTLIMIT = 3;
        private int QUIT = -1;
        int inputCounter;
        private int rating = 0;
        private int StarAccumulator;
        private string userName;

        public void DisplayRating()
        {

            Housekeeping();

            while (rating != QUIT)
            {
                DetailLoop();
            }
            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Please enter your movie rating or exit with -1");
            rating = Convert.ToInt32(Console.ReadLine());
            inputCounter += 1;

        }

        private void DetailLoop()
        {
            Console.WriteLine("Enter user name: ");
            userName = Console.ReadLine();
            

            if (rating < 0 || rating > 4)
            {
                //int inputCounter = 1;

                while (inputCounter < INPUTLIMIT)
                {
                    Console.WriteLine("Incorrect input. Please try again.");
                    rating = Convert.ToInt32(Console.ReadLine());
                    inputCounter += 1;
                }
                Console.WriteLine("You've reached the limit of incorrect answers. Your account will be reseted");
            }
            else
            {
                Console.WriteLine("Your avarage rating is: " + rating);
            }
            Console.WriteLine("Please enter your movie rating or exit with -1");
            inputCounter = default(int);
            rating = Convert.ToInt32(Console.ReadLine());
            inputCounter += 1;
        }

        private void EndOfJob() { Console.WriteLine("Program end"); }
    }
}