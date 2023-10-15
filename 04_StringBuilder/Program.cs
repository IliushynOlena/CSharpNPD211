using System.Text;

namespace _04_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";//5b
            str += ", world!!!";//10b
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";
            str += ", world!!!";

            //str.Insert()
            //char.IsUpper('A');
            StringBuilder b = new StringBuilder();
            b.AppendLine("bla");

            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");

            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.AppendLine("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");
            b.Append("bla");
            b.Append("bla");
            b.Append("bla");
            b.Append("bla");
            b.Append("bla");
            Console.WriteLine($" Length : {b.Length}");
            Console.WriteLine($" Capacity : {b.Capacity}");

            Console.WriteLine(b);




        }
    }
}