using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntroToOOP
{
    partial class Point
    {
        public void SetX(int x)
        {
            if (x >= 0)
                xCoord = x;
            else
                xCoord = 0;

        }
        public void SetY(int y)
        {
            if (y >= 0)
                yCoord = y;
            else
                yCoord = 0;

        }
        public int getX()
        {
            return xCoord;
        }
        public int getY()
        {
            return yCoord;
        }
    }
    partial class Point
    {
        public void Print()
        {
            Console.WriteLine($"X {xCoord}, Y {yCoord}");
        }
        public override string ToString()
        {
            return $"Name {Name} .X {xCoord}, Y {yCoord}";
        }
    }
}


namespace _05_IntroToOOP
{
    partial class Point
    {
        public void Test()
        {
            Console.WriteLine("Test method");
        }

    }



}
