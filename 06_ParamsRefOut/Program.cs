namespace _06_ParamsRefOut
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X : {X}  Y : {Y}";
        }
    }
    internal class Program
    {
        //Params
        static void MethodWithParams(string name,  params int[]marks)
        {
            Console.WriteLine($"-------------{name}-------------");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
        }
        static void MethodWithParams(string name , int a, int b, int c, params int[] marks)
        {
            Console.WriteLine($"-------------{name}-------------");
            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = "+ b);
            Console.WriteLine("c = "+ c);
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
        }
        //ref
        static void Modify(ref int num,ref string str,ref Point point )
        {
            //num += 1;
            //str += "!!!!";
            point.X++;
            point.Y++;
           
        }
        static void GetCurrentTime(out int hour,out int minute,out int second)
        {
            //Console.WriteLine($"{hour}:{minute}:{second}");
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;   
            second = DateTime.Now.Second;
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
        static void Main()
        {
            //Out
            int h, m, s;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurrentTime(out h,out m,out s);
            Console.WriteLine($"{h}:{m}:{s}");
            //Ref
            int num = 10;//10
            string str = "Hello academy";
            Point point = new Point() {  X = 5, Y = 6};
            Console.WriteLine("Num = " + num);
            Console.WriteLine("Str = " + str);
            Console.WriteLine("Point = " + point);
            //     10,address 0c1478 
            Modify(ref num,ref str,ref point);
            Console.WriteLine("Num = " + num);
            Console.WriteLine("Str = " + str);
            Console.WriteLine("Point = " + point);

            /*
            //Params
            //int[], string[]arr - Array
            int[] marks = new int[] { 11, 12, 10, 9, 8, 7, 6, 12, 10, 11 };
            MethodWithParams("Bob",marks);
            MethodWithParams("Tom",new int[] {8,9,7,6,5});
            MethodWithParams("Jack",8,9,7,6,5,12,10,11,12,12,12,12,11,10,12,8);
            */

        }
    }
}