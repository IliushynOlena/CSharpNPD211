using System.Runtime.CompilerServices;

namespace _07_OverloadOperators
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x, int y , int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point3D d &&
                   X == d.X &&
                   Y == d.Y &&
                   Z == d.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //ref and out - not allowed
        // public static return_type operator[symbol](paramaters){//code}
        #region Унарні оператори
        public static Point operator-(Point p)
        {
            Point point = new Point { X = -p.X, Y = -p.Y };
            return point;
        }
        public static Point operator++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Бінарні оператори
        public static Point operator +(Point p1, Point p2)
        {
            Point point = new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return point;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point point = new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return point;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point point = new Point
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return point;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point point = new Point
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return point;
        }
        #endregion

        #region Оператори порівняння
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
            //return p1.X == p2.X && p1.Y == p2.Y;
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
            //return p1.X == p2.X && p1.Y == p2.Y;
        }
        #endregion
        #region Логічні оператори
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X + p1.Y < p2.X + p2.Y;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.X + p1.Y <= p2.X + p2.Y;
        }
        #endregion
        #region True/false operators
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }
        #endregion
        #region Оператори перетворення типів даних
        public static implicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X * p.Y;
        }
        public static explicit operator Point3D(Point p)
        {
            return new Point3D(p.X, p.Y, 0);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;//int => int
            double b = 6.7;//double=>double;

            b = a;//int => double implicit 5.000000000
            a = (int) b;//double => int explicit 6
            Point test = new Point(5, 5);
            a = test;//Point => int
            Console.WriteLine(a);
            b = test;//Point => double
            Console.WriteLine(b);
            Point3D point3D =(Point3D) test;//Point => Point3D
            Console.WriteLine(point3D);

            //object obj = new object();
            //obj.Equals("Hello");

            //string str = "Hello";
            //string str2 = "Hello";
            //string str3 = "Hello";
            //string str4 = "Hello";
            //string str5 = "Hello";
            //string str6 = "Hello";
            //string str7 = "Hello";
            //if (str.Equals(str2))
            //    Console.WriteLine("References is equals");
            //else
            //    Console.WriteLine("References is not equals");


            Point point1 = new Point(0, 0);
            Point point2 = new Point(5, 9);

            if(point1)
                Console.WriteLine("Point is true");
            else
                Console.WriteLine("Point is false");


            if (point1==point2)
                Console.WriteLine("Point1 == point 2");
            else
                Console.WriteLine("Point1 != point 2");

            if (point1 > point2)
                Console.WriteLine("Point1 > point 2");
            else
                Console.WriteLine("Point1 < point 2");

            if (point1 < point2)
                Console.WriteLine("Point1 < point 2");
            else
                Console.WriteLine("Point1 > point 2");


            Console.WriteLine("Point 1 ++ "+ point1++);
            Console.WriteLine("++ Point 1  "+ ++point1);
            Console.WriteLine("Point 1 --  "+ point1--);
            Console.WriteLine("--Point 1   "+ --point1);

            Point res = -point1;
            Console.WriteLine("Res point : " + res);
            res = point1 + point2;
            Console.WriteLine("Res point1 + point2 : " + res);
            res = point1 - point2;
            Console.WriteLine("Res point1 - point2 : " + res);
            res = point1 * point2;
            Console.WriteLine("Res point1 * point2 : " + res);
            res = point1 / point2;
            Console.WriteLine("Res point1 / point2 : " + res);



        }
    }
}