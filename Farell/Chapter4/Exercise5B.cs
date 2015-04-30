using System;

namespace Farrell.Chapter4
{
    public class Exercise5B
    {
        private const int AGEFILTER = 35;
        private int age;
        private int policyNumber;

        public void DisplayPolicyHoldersByAge()
        {
            Housekeeping();
            while (age != -1)
            {
                DetailLoop();
            }
            Finish();

        }

        private void Finish()
        {
        }

        private void DetailLoop()
        {
            if (age > AGEFILTER)
            {
                Console.WriteLine("Your policy holder data is: Age: {0}, policy number: {1}", age,
                    policyNumber);
            }

            Console.WriteLine("Please enter your age or quit with -1: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your policy number: ");
            policyNumber = Convert.ToInt32(Console.ReadLine());


        }

        private void Housekeeping()
        {
            Console.WriteLine("Policy holder age filter program.");

            Console.WriteLine("Please enter your age or quit with -1: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your policy number: ");
            policyNumber = Convert.ToInt32(Console.ReadLine());

        }
    }
}