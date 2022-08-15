

namespace Project_num1
{
    internal class UC1

    {
        int x1 = 1;
        int y1 = 2;
        int x2 = 3;
        int y2 = 4;

        double LengthLine = 0;

        public void CartesianSystem()
        {
            LengthLine = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            Console.WriteLine(Math.Sqrt(LengthLine));

        }

    }
}
