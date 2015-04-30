using System;

namespace Farrell.Chapter6
{
    public class Exercise2A
    {
        private const int Size = 10;
        private int[] _numberArray = new int[Size];
        private int _counter;
        private int _number;
        private int _accum;
        private int _average;

        public void ShowNumbersAndDifference()
        {
            GetReady();
            InputArray();
            ShowDiff();
            FinishUp();
        }

        private void GetReady()
        {
            _counter = 0;
            Console.WriteLine("Please enter number {0} of {1}: ", _counter + 1, _numberArray.Length);
            _number = Convert.ToInt32(Console.ReadLine());

            _numberArray[_counter] = _number;
            _counter += 1;
        }

        private void InputArray()
        {
            while (_counter<_numberArray.Length)
            {
                Console.WriteLine("Please enter number {0} of {1}: ", _counter + 1, _numberArray.Length);
                _number = Convert.ToInt32(Console.ReadLine());
                _numberArray[_counter] = _number;
                _counter += 1;
            }
        }

        private void ShowDiff()
        {
            _counter = 0;
            
            while (_counter<_numberArray.Length )
            {
                _accum += _numberArray[_counter];
                _counter += 1;

            }
            _average = _accum / _numberArray.Length;
            Console.WriteLine("Your array's difference from numeric average is: {0}",_average);
        }

        private void FinishUp()
        {
            Console.WriteLine("Program ended");
        }
    }
}