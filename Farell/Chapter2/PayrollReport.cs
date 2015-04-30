using System;

namespace Farrell.Chapter2
{
    public class PayrollReport
    {
        private const string ReportHeading = "Payroll Report";
        private const string ColumnHeading = "Name Gross Deductions Net";
        private const double RATE = 0.25;
        private const string Quit = "XXX";
        private const string END_LINE = "**End of report";
        private double _deduct;
        private int _gross;
        private string _name;
        private double _net;

        public void ShowPayrollReport()
        {
            HouseKeeping();

            while (_name != "QUIT")
                DetailLoop();

            EndOfJob();
        }

        private void EndOfJob()
        {
            Console.WriteLine(END_LINE);
        }

        private void DetailLoop()
        {
            Console.WriteLine("Please enter employee name: ");
            _name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter gross-salary: ");
            _gross = Convert.ToInt32(Console.ReadLine());
            _deduct = _gross * RATE;
            _net = _gross - _deduct;
            Console.WriteLine(
                "Your name is {0}. Gross-Salary is {1}. Deduct is {2}. Net-Salary is {3}", _name,
                _gross, _deduct, _net);

            Console.WriteLine("Please enter employee name: ");
            _name = Convert.ToString(Console.ReadLine());
        }

        private void HouseKeeping()
        {
            Console.WriteLine("ReportHeading is: " + ReportHeading);
            Console.WriteLine("ColumnHeading is: " + ColumnHeading);

       
        }
    }
}