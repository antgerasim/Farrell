using System;

namespace Farrell.Chapter4
{ //s.179

    public class Exercise5A
    {
        private static int POLICY_RANGE_ = 9999;
        private static int POLICY_RANGE_FROM = 1000;
        private int age;
        private string firstName;
        private int incidentNumber;
        private string lastName;
        private int policyNumber;
        private int premiumDueDay;
        private int premiumDueMonth;
        private int premiumDueYear;

        public void ShowPolicyData()
        {
            Housekeeping();
            Detail();
            Finish();
        }

        private void Detail()
        {
            if (policyNumber < 1000)
            {
                policyNumber = 0;
            }
            else
            {
                if (policyNumber > 9999)
                {
                    policyNumber = 0;
                }
            }
            if (premiumDueMonth < 1)
            {
                premiumDueMonth = 0;
            }
            else
            {
                if (premiumDueMonth > 12)
                {
                    premiumDueMonth = 0;
                }
            }
            //start switch

            #region premiumDueMonth switch

            if (premiumDueMonth == 1)
            {
                if (premiumDueDay < MonthRangesConstants.JAN_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;
                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.JAN_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 2)
            {
                if (premiumDueDay < MonthRangesConstants.FEB_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;

                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.FEB_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 3)
            {
                if (premiumDueDay < MonthRangesConstants.MARCH_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;
                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.MARCH_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 4)
            {
                if (premiumDueDay < MonthRangesConstants.APR_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;
                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.APR_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 5)
            {
                if (premiumDueDay < MonthRangesConstants.MAY_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;
                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.MAY_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 6)
            {
                if (premiumDueDay < MonthRangesConstants.JUN_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;

                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.JUN_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;

                    }
                }
            }
            else if (premiumDueMonth == 7)
            {
                if (premiumDueDay < MonthRangesConstants.JUL_DAY_RANGE_FROM)
                {

                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;

                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.JUL_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }
            else if (premiumDueMonth == 8)
            {
                if (premiumDueDay < MonthRangesConstants.AUG_DAY_RANGE_FROM)
                {
                    premiumDueDay = 0;
                    premiumDueMonth = 0;
                    premiumDueYear = 0;

                }
                else
                {
                    if (premiumDueDay > MonthRangesConstants.AUG_DAY_RANGE_TO)
                    {
                        premiumDueDay = 0;
                        premiumDueMonth = 0;
                        premiumDueYear = 0;
                    }
                }
            }

            #endregion

            DisplayPolicyData();

        }

        private void DisplayPolicyData()
        {
            Console.WriteLine("Your entered customer data is: {0},{1},{2},{3}", policyNumber,
                firstName, lastName, age);
            Console.WriteLine("Your validated Premium Due Day, Month, Year is: {0}, {1}, {2} ",
                premiumDueDay, premiumDueMonth, premiumDueYear);
        }

        private void Housekeeping()
        {
#if DEBUG
            Console.WriteLine("Please enter your premiumDueDay:  ");
            premiumDueDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your premiumDueMonth:  ");
            premiumDueMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your premiumDueYear:  ");
            premiumDueYear = Convert.ToInt32(Console.ReadLine());
#else
            Console.WriteLine("Drive-Rite Insurance Company");

            Console.WriteLine("Please enter your policy-number: ");
            policyNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your firstname: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your lastname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your premiumDueDay:  ");
            premiumDueDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your premiumDueMonth:  ");
            premiumDueMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your premiumDueYear:  ");
            premiumDueYear = Convert.ToInt32(Console.ReadLine());
#endif

        }

        private void Finish()
        {
            Console.WriteLine("Program ended");
        }
    }

    internal static class MonthRangesConstants
    {
        internal static int APR_DAY_RANGE_FROM = 1;
        internal static int APR_DAY_RANGE_TO = 30;
        internal static int AUG_DAY_RANGE_FROM = 1;
        internal static int AUG_DAY_RANGE_TO = 31;
        internal static int FEB_DAY_RANGE_FROM = 1;
        internal static int FEB_DAY_RANGE_TO = 29;
        internal static int JAN_DAY_RANGE_FROM = 1;
        internal static int JAN_DAY_RANGE_TO = 31;
        internal static int JUL_DAY_RANGE_FROM = 1;
        internal static int JUL_DAY_RANGE_TO = 31;
        internal static int JUN_DAY_RANGE_FROM = 1;
        internal static int JUN_DAY_RANGE_TO = 30;
        internal static int MARCH_DAY_RANGE_FROM = 1;
        internal static int MARCH_DAY_RANGE_TO = 31;
        internal static int MAY_DAY_RANGE_FROM = 1;
        internal static int MAY_DAY_RANGE_TO = 31;
    }

    internal static class YearRangesConstants
    {
        internal static int YEAR_MONTH_RANGE_FROM = 1;
        internal static int YEAR_MONTH_RANGE_TO = 12;
    }
}