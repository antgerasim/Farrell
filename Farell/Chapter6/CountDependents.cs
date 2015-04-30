using System;

namespace Farrell.Chapter6
{
    public class CountDependentsClass
    {
        private const int Quit = 999;
        private int[] _count = new int[6];
        private int _dep;

        public void ShowCountDependents()
        {
            GetReady();
            while (_dep != Quit)
            {
                CountDependents();
            }
            FinishUp();
        }

        private void GetReady()
        {
            Console.WriteLine("Enter dependents or " + Quit + " to quit: ");
            _dep = Convert.ToInt32(Console.ReadLine());
        }

        private void CountDependents()
        {
            _count[_dep] += 1;
            Console.WriteLine("Enter dependents or " + Quit + " to quit: ");
            _dep = Convert.ToInt32(Console.ReadLine());
        }

        private void FinishUp()
        {
            Console.WriteLine("Dependents Count");
            _dep = 0;
            while (_dep < 6)
            {
                Console.WriteLine("dep is: {0}, count[dep] is: {1}", _dep, _count[_dep]);
                _dep += 1;
            }
        }
    }
}