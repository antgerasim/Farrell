using System;

namespace Farrell.Chapter5
{
    public class Exercise1
    {
        public void ShowAllOutPutSegements()
        {
            //ShowOutPutSegementA();
            //ShowOutPutSegementB();
            //ShowOutPutSegementC();
            //ShowOutPutSegementD();
            //ShowOutPutSegementE();
            ShowOutPutSegementF();
        }

        private void ShowOutPutSegementA()
        {
            int a = 1, b = 2, c = 5;
            int count = 0;

            while (a < c)
            {
                a = a + 1;
                b = b + c;
                count++;
            }
            Console.WriteLine("a is: {0}, b is: {1}, c is: {2}", a, b, c);
        }

        private void ShowOutPutSegementB()
        {
            int d = 4, e = 6, f = 7;

            while (d > f)
            {
                d = d + 1;
                e = e - 1;
            }
            Console.WriteLine("d is: {0}, e is: {1}, f is: {2}", d, e, f);
        }

        private void ShowOutPutSegementC()
        {
            int g = 4, h = 6;

            while (g > h)
            {
                g = g + 1;
            }
            Console.WriteLine("g is: {0}, h is: {1}", g, h);
        }

        private void ShowOutPutSegementD()
        {
            int j = 2, k = 5, n = 9;

            while (j < k)
            {
                var m = 6;

                while (m < n)
                {
                    Console.WriteLine("Goodbye");
                    m = m + 1;
                }
                j = j + 1;
            }

            Console.WriteLine("j is: {0}, k is: {1}, n is: {2}, ", j, k, n);
        }

        private void ShowOutPutSegementE()
        {
            int j = 2, k = 5, m = 6, n = 9;

            while (j < k)
            {
                while (m < n)
                {
                    Console.WriteLine("Hello");
                    m = m + 1;
                }
                j += 1;
            }
            Console.WriteLine("j is: {0}, k is: {1}, m is: {2}, n is: {3}, ", j, k, m, n);
        }

        private void ShowOutPutSegementF()
        {
            int p = 2, q = 4;

            while (p < q)
            {
                Console.WriteLine("Adios");
                int r = 1;
                while (r < q)
                {
                    Console.WriteLine("Adios");
                    r += 1;
                }
                p += 1;
            }
            Console.WriteLine("p is: {0}, q is: {1} ", p, q);
        }
    }
}