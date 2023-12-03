namespace _12_Delegates
{

    public delegate void DoubleDelegate(double a); 
    public delegate int IntDelegate(); 


    public delegate void SetStringDelegate(string str); 
    public delegate double GetDoubleDelegate(); 
    public delegate void VoidDelegate(); 


    public class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine("String " + str);
        }
        public static double GetKoef()
        {
            return new Random().NextDouble();   
        }
        public double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("Doing work");
        }
        public void Test()
        {
            Console.WriteLine("Testing.....");
        }

    }
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            throw new DivideByZeroException();
        }
    }

    public delegate int ChangeDelegate(int v);
    internal class Program
    {
        public static void DoOperation(double a, double b, CalcDelegate operation)
        {
            Console.WriteLine(operation.Invoke(a, b));
        }
        public static int Incrementer(int v)
        {
            return ++v;
        }
        public static int Decrementer(int v)
        {
            return --v;
        }
      
        public static int PlusTen(int v)
        {
            return v+10;
        }
        public static void ChangeElement(int[] arr, ChangeDelegate change)
        {
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i]=  change(arr[i]);
            }
        }
        static void Main(string[] args)
        {      

            int[] arr = new int[] { 5, 7, 36, 14, 25, 33, 89, 9 };
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeElement(arr, Incrementer);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            //ChangeElement(arr, Decrementer);
            ChangeElement(arr, delegate(int v) { return --v; });
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            ChangeElement(arr, v=> v * v);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            ChangeElement(arr, PlusTen);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();




            Calculator calculator = new Calculator();

            DoOperation(100, 12, calculator.Div);
            DoOperation(100, 12, calculator.Add);
            DoOperation(100, 12, calculator.Sub);
            DoOperation(100, 12, calculator.Multy);

            Console.WriteLine("------------------------");
            CalcDelegate operation = calculator.Add;
            operation += calculator.Sub;
            operation += calculator.Multy;
            operation += calculator.Div;
            operation -= calculator.Div;

            Console.WriteLine("Last operation : " + operation(10, 5));

            foreach (CalcDelegate item in operation.GetInvocationList())
            {
                Console.WriteLine($" {item.Method.Name} - Result {item.Invoke(145, 3)}");
            }

            /*
            Calculator calculator = new Calculator();
            double x, y;
            int key;
            do
            {
                CalcDelegate calcDelegate = null;
                Console.WriteLine("Enter first number ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Add  - 1 ");
                Console.WriteLine("Sub  - 2 ");
                Console.WriteLine("Mult  - 3 ");
                Console.WriteLine("Divide  - 4 ");
                Console.WriteLine("Exit  - 0 ");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalcDelegate(calculator.Add);
                        break;
                    case 2:
                        calcDelegate = new CalcDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multy;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good  Buy");
                        break;
                    default:
                        Console.WriteLine("Error choice......");
                        break;
                }

                Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            } while (key != 0);
            */
            /*
            SuperClass superClass = new SuperClass();
            Console.WriteLine(SuperClass.GetKoef()); 
            ;

            //GetDoubleDelegate method = new GetDoubleDelegate(SuperClass.GetKoef);
            GetDoubleDelegate method =SuperClass.GetKoef;
            //Console.WriteLine(method());
            Console.WriteLine(method?.Invoke());


            GetDoubleDelegate[] delArr = new GetDoubleDelegate[]
            {
                SuperClass.GetKoef,
                new GetDoubleDelegate(superClass.GetNumber)
            };

            Console.WriteLine(delArr[0]?.Invoke());
            Console.WriteLine(delArr[1]?.Invoke());


            SetStringDelegate setString = new SetStringDelegate(superClass.Print);
            VoidDelegate voidDelegate = new VoidDelegate(superClass.Test);
            setString?.Invoke("Hello world");
            voidDelegate.Invoke();


            GetDoubleDelegate dblDelegate = new GetDoubleDelegate(SuperClass.GetKoef);
           // Delegate.Combine(dblDelegate, new GetDoubleDelegate(superClass.GetNumber));
            //dblDelegate += new GetDoubleDelegate(superClass.GetNumber);
            dblDelegate += superClass.GetNumber;
            Console.WriteLine("-----------------------------");

            foreach (GetDoubleDelegate item in dblDelegate.GetInvocationList())
            {
                Console.WriteLine(item.Invoke()); 
            }


            Console.WriteLine("Last delegate : " + dblDelegate.Invoke());
            */
        }
    }
}