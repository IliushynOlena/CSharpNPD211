using System.Collections.Specialized;

namespace _14_Extensions
{
    public static class MyString 
    {
        public static int NumberWords(this string data)
        {
            if(string.IsNullOrEmpty(data))
                return 0;

            return data.Split(new char[] { ' ',',','.' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int NumberSymbolsInWords(this string data, char s)
        {
            if (string.IsNullOrEmpty(data))
                return 0;

            int count = 0;
            //read only
            foreach (char c in data)
            {
                if (c == s) count++;
                
            }

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] == s) count++;
            //}
            return count;
        }
    }

    class ExampleNameOf
    {
        public string Name { get; set; }
        public ExampleNameOf(string Name)
        {
            if (Name == null)
                throw new ArgumentNullException(nameof(Name));

            this.Name = Name;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            string str = "1";
            string copy;//null
            if (true)
            {
                int b = 10;
                string str2 = "2";//0c2c2c
                copy = str2;//0c2c2c = 0c2c2c
                Console.WriteLine(b);
                Console.WriteLine(str2);
            }
            //Console.WriteLine(b);
            // Console.WriteLine(str2);
            Console.WriteLine(copy);
           // Console.WriteLine(copy + str);


            try
            {
                ExampleNameOf nameOf = new ExampleNameOf(null);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //int - number
            //int[] - Array
            //string[]- Array
            Console.WriteLine("Enter string : ");
            string message = Console.ReadLine();

            Console.WriteLine($"Number words : {message.NumberWords()}");
            Console.WriteLine($"Number symbol 'o' in  message : {message.NumberSymbolsInWords('o')}");

           

            
        }
    }
}