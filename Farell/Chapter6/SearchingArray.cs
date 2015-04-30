using System;

namespace Farrell.Chapter6
{
    public class SearchingArray
    {
        private const string Msg_Yes = "Item availible";
        private const string Msg_No = "Item not found";
        private const int Finish = 999;
        //private const int Size = 6; // array Length instead
        private static readonly int[] Valid_Item = {106, 108, 307, 405, 457, 688};
        private int badItemCount = 0;
        private string foundIt;
        private int item;
        private int sub;

        public void ShowSearchedArray()
        {
            GetReady();

            while (item != Finish)
            {
                FindItem();
            }

            FinishUp();

        }

        private void GetReady()
        {
            Console.WriteLine("Enter item number or {0} to quit: ", Finish);
            item = Convert.ToInt32(Console.ReadLine());
        }

        private void FindItem()
        {
            foundIt = "N";
            sub = 0;

            while (sub < Valid_Item.Length)
            {
                if (item == Valid_Item[sub])
                {
                    foundIt = "Y";
                }
                sub += 1;
            }

            if (foundIt == "Y")
            {
                Console.WriteLine(Msg_Yes);
            }
            else
            {
                Console.WriteLine(Msg_No);
                badItemCount += 1;
            }
            Console.WriteLine("Enter next item number or {0} to quit: ", Finish);
            item = Convert.ToInt32(Console.ReadLine());
        }

        private void FinishUp() { Console.WriteLine(badItemCount + " items had invalid numbers"); }
    }
}