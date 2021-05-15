using System;
// Comment from erich
namespace Test_first_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 45;
            int z = 70;

            int max = 0;


            if (x > max)
            {
                max = x;
            }
            if (y > max)
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }
            Console.WriteLine(max);

        }
    }
}
