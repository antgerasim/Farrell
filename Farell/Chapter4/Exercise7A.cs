using System;

namespace Farrell.Chapter4
{
    public class Exercise7A
    {
        private const int BASE_PRICE = 200;
        private const int SURFACE_CHARGE = 50;
        private const int MAHOGONY_CHARGE = 150;
        private const int OAK_CHARGE = 125;
        private const int PINE_CHARGE = 0;
        private const int DRAWER_CHARGE = 30;
        private const int SURFACE_MAX = 750;
        // private int _customerBill;
        private string _customerName;
        private int _deskLength;
        private int _deskWidth;
        private int _numberDrawes;
        private int _orderId;
        private string _woodType;

        public Exercise7A(string customerName, int deskLength, int deskWidth, int numberDrawes,
            int orderId, string woodType)
        {
            _customerName = customerName;
            _deskLength = deskLength;
            _deskWidth = deskWidth;
            _numberDrawes = numberDrawes;
            _orderId = orderId;
            _woodType = woodType;
        }

        public Exercise7A() { }

        public void DisplayCustomerBill()
        {
            Housekeeping();

            Detail();

            Finish();
        }

        private void Housekeeping()
        {
            Console.WriteLine("Rick Hammer Carpenter Program");
            Console.WriteLine("Please enter your customer name: ");
            _customerName = Console.ReadLine();
        }

        private void Detail()
        {
            DataInput();

            var result = CalcCustomerBill();

            Console.WriteLine(
                "Your order number is: {0}, customerName: {1}, desklength: {2}, deskwidth: {3}, woodType: {4}, number of drawes: {5}",
                _orderId, _customerName, _deskLength, _deskWidth, _woodType, _numberDrawes);

            Console.WriteLine("Your customer bill is: {0}", result);

            Console.WriteLine("Input name: ");

            _customerName = Console.ReadLine();

        }

        private int CalcCustomerBill()
        {
            var result = BASE_PRICE; //+200

            result += SurfaceBarrier(CalcSurface()); //+50
            result += CheckWoodType(); //+150
            result += CalcDrawerTotal(); //+120

            return result; //
        }

        private void DataInput()
        {
            Console.WriteLine("Please enter your order number: ");
            _orderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your desk length: ");
            _deskLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your desk width: ");
            _deskWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your desired wood type: ");
            _woodType = Console.ReadLine();

            Console.WriteLine("Please enter number of drawes: ");
            _numberDrawes = Convert.ToInt32(Console.ReadLine());
        }

        private int CheckWoodType()
        {
            if (_woodType.Equals("mahogany"))
            {
                return MAHOGONY_CHARGE;
            }
            else if (_woodType.Equals("oak"))
            {
                return OAK_CHARGE;
            }
            else if (_woodType.Equals("pine"))
            {
                return PINE_CHARGE;
            }
            return 0;
        }

        private int SurfaceBarrier(int surface)
        {
            return surface > SURFACE_MAX ? SURFACE_CHARGE : 0;
        }

        protected int CalcSurface() { return _deskLength * _deskWidth; }

        private int CalcDrawerTotalParam(int x) { return x * DRAWER_CHARGE; }

        private int CalcDrawerTotal() { return _numberDrawes * DRAWER_CHARGE; }

        private void Finish() { Console.WriteLine("End of program"); }
    }
}