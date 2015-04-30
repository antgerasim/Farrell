using System;

namespace Farrell.Chapter5
{
    public class QuizAnswerSheets
    {
        private const string Line = ". ___";
        private const string PartLabel = "Part ";
        private const int Parts = 5;
        private const int Questions = 3;
        private const string Quit = "QUIT";
        private int _partCounter;
        private int _questionCounter;
        private string quizName;

        public void PrintSheets()
        {
            Housekeeping();
            while (!quizName.Equals(Quit))
            {
                DetailLoop();
            }

            EndOfJob();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Enter quiz name or \"QUIT\" to quit: ");
            quizName = Console.ReadLine();
        }

        private void DetailLoop()
        {
            Console.WriteLine(quizName);
            _partCounter = 1;

            while (_partCounter <= Parts)
            {
                Console.WriteLine(PartLabel + " " + _partCounter);
                _questionCounter = 1;

                while (_questionCounter <= Questions)
                {
                    Console.WriteLine(_questionCounter + " " + Line);
                    _questionCounter += 1;
                }
                _partCounter += 1;
            }
            Console.WriteLine("Enter next quiz name or \"QUIT\" to quit: ");
            quizName = Console.ReadLine();
        }

        private void EndOfJob() { Console.WriteLine("Program ended"); }
    }
}