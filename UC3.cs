using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_num1
{
    internal class UC3

    {
        int x1 = 2;
        int x2 = 3;
        int y1 = 4;
        int y2 = 5;

        double LengthLine1 = 0;

        int a1 = 6;
        int a2 = 7;
        int b1 = 8;
        int b2 = 9;

        double LengthLine2 = 0;

        public void CartesianSystem()
        {
            LengthLine1 = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            Console.WriteLine(Math.Sqrt(LengthLine1));

            LengthLine2 = ((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1));
            Console.WriteLine(Math.Sqrt(LengthLine2));

            Console.WriteLine(LengthLine1.Equals(LengthLine2));

           // UC3

            Console.WriteLine(LengthLine1.CompareTo(LengthLine2));

            public void Equality()

            if (LengthLine1 == LengthLine2)
            {
                Console.WriteLine("Line1 and line2 are equal");
            }
            else if (LengthLine1.CompareTo(LengthLine2) == 1)
            {
                Console.WriteLine("Line1 is greater than Line2");

            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
        }

    }
}



