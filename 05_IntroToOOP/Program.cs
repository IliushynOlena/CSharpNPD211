using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace _05_IntroToOOP
{
    /*
    - private
    - public
    - protected
    - internal
    - protected internal
     */
    class MyClass// : Object
    {
        private int number;
        private string name;
        private const float PI = 3.14f;
        private readonly int id;
        public MyClass()
        {
            id = 10;
        }
        //void SetId(int id)
        //{
           
        //    this.id = id;
        //}
        public void Print()
        {
            Console.WriteLine($"Id {id}, Name {name}");
        }
        public override string ToString()
        {
            return $"Id {id}, Name {name}";
        }
    }
    class DerivedClass :  MyClass
    {

    }

    partial class Point
    {
        //Full Property
        private int xCoord;
        public int XCoord
        {
            get
            {
                return xCoord;
            }
            set//value
            {
                if (value >= 0)
                    xCoord = value;
                else
                    xCoord = 0;
            }
        }

        private int yCoord;
        public int YCoord
        {
            get
            {
                return yCoord;
            }
            set//value
            {
                if (value >= 0)
                    yCoord = value;
                else
                    yCoord = 0;
            }
        }

        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto-properti  prop+Tab
        public string Name { get; set; }
        public string Type { get; }//readonly
        public string Address { get; private set; }

        //propfull + Tab + Tab
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    age = 0;
            }
        }
        static int count;
        static Point()
        {
            count = 0;
        }

        public Point() : this(0, 0) { }

        public Point(int value) : this(value, value) { }
        public Point(int x, int yCoord)//-10 -5
        {
            //SetX(x);
            //SetY(yCoord);
            XCoord = x;//setter
            YCoord = yCoord;
            count++;
        }
       
      
    }

    struct MyStruct
    {
        public int x;
        public int y;
        public void Print()
        {
            Console.WriteLine($"X {x}, Y {y}");
        }
    }
    class Program
    {
        static void Main()
        {
            Point point = new Point(-10,8);
            point.Print();
            Console.WriteLine(point);

            point.SetX(15);
            point.SetY(25);
            Console.WriteLine(point);
            point.SetY(7);

            Console.WriteLine($"X = {point.getX()}"  ); 
            Console.WriteLine($"Y = {point.getY()}"  );
            //             value
            point.XCoord = 100;//setter
            int x = point.XCoord;//getter
            Console.WriteLine(x);

            point.Name = "2D_Point";//set
            Console.WriteLine(point.Name);//get
            Console.WriteLine(point);

            Point newPoint = new Point(22);
            Console.WriteLine(newPoint);

            point.Test();





            //int a = 5;
            //MyClass myClass = new MyClass();
           
            //myClass.Print();
            //Console.WriteLine(myClass.ToString());//cout << point; cout << animal;
            //MyClass @class = new MyClass();
            //@class.Print();
            //MyClass.Print();

        }
    }

   
}
