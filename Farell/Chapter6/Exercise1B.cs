using System;

namespace Farrell.Chapter6
{
    public class Exercise1B
    {
        private const int Size = 10;
        private const int Quit = -1;
        private int _counter;
        private int _number;
        private readonly int[] _inputArray = new int[Size];

        public void DisplayReverseArray()
        {
            GetReady();
            while (_number != Quit)
            {
                InputArray();
                InverseArray();
            }
            FinishUp();
        }

        private void GetReady()
        {
            _counter = 0;
            Console.WriteLine("Please enter number {0} of {1}:  or quit with {2}", _counter + 1,
                _inputArray.Length, Quit);
            _number = Convert.ToInt32(Console.ReadLine());
            _inputArray[_counter] = _number;
            _counter += 1;
        }

        private void InputArray()
        {
            while (_counter < _inputArray.Length)
            {
                Console.WriteLine("Please enter number {0} of {1}: ", _counter + 1,
                    _inputArray.Length);
                _number = Convert.ToInt32(Console.ReadLine());
                _inputArray[_counter] = _number;
                _counter++;
            }
            Console.WriteLine(Environment.NewLine);
        }

        private void InverseArray()
        {
            Console.WriteLine("Your entered array in reverse order: ");
            _counter = 0;
            while (_counter < _inputArray.Length)
            {
                Console.WriteLine(_inputArray[_inputArray.Length - (_counter + 1)]);
                _counter += 1;
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Would you like to continue? ");
            _counter = 0;
            Console.WriteLine("Please enter number {0} of {1}:  or quit with {2}", _counter + 1,
                _inputArray.Length, Quit);
            _number = Convert.ToInt32(Console.ReadLine());
        }

        private void FinishUp() { Console.WriteLine("Program ended"); }
    }
}