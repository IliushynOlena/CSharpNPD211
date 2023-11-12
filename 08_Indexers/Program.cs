namespace _08_Indexers
{
    class Laptop
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Model {Model}. Price {Price}$";
        }
    }
    class Shop
    {
        Laptop[] laptopArr;
        public Shop(int size)
        {
            laptopArr = new Laptop[size]; //10  
        }
        public int Length { get { return laptopArr.Length; } }

        public Laptop GetLaptop(int index)//55
        {
            if (index >= 0 && index < laptopArr.Length)
                return laptopArr[index];
            else
                throw new IndexOutOfRangeException();
        }
        public void SetLaptop(int index, Laptop laptop)
        {
            if (index >= 0 && index < laptopArr.Length)
                 laptopArr[index] = laptop;
            else
                throw new IndexOutOfRangeException();
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                    return laptopArr[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < laptopArr.Length)
                    laptopArr[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[string model]
        {
            get
            {
                //Read only
                foreach (var laptop in laptopArr)
                {
                    if(laptop.Model== model)
                        return laptop;
                }
                return null;
            }
            //private set
            //{
            //    for (int i = 0; i < laptopArr.Length; i++)
            //    {
            //        if (laptopArr[i].Model == model)
            //        {
            //            laptopArr[i] = value;
            //            break;
            //        }

            //    }

            //}
        }
        public int FindByPrice(decimal price)
        {
            for (int i = 0; i < laptopArr.Length; i++)
            {
                if (laptopArr[i].Price == price)
                {
                    return i;
                }
            }
            return -1;
        }
        public Laptop this[decimal price]
        {
            get
            {
                int index = FindByPrice(price);
                if(index != -1)
                {
                    return laptopArr[index];
                }
                throw new Exception("Incorrect price!!!!");
            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                {
                   this[index] = value;
                }
            }

        }
    }
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MultArray multArray = new MultArray(2, 3);

            for (int i = 0; i < multArray.Rows; i++)
            {
                for (int j = 0; j < multArray.Cols; j++)
                {
                    multArray[i, j] = i + j;//indexator - set
                    Console.Write($"{multArray[i, j]} ");//indexator - get
                }
                Console.WriteLine();
            }
            */
            Shop shop = new Shop(3);

            shop.SetLaptop(0, new Laptop() { Model = "HP", Price = 25233.99m });
            var laptop = shop.GetLaptop(0);
            Console.WriteLine(laptop);

            shop[1] = new Laptop() { Model = "Asus", Price = 33333.33m };//setter
            shop[2] = new Laptop() { Model = "DELL", Price = 45000.99m };//setter
            laptop = shop[1];//getter
            Console.WriteLine(laptop);

            shop[33333.33m] = new Laptop();//setter
            Console.WriteLine(shop[25233.99m]);
            
            Console.WriteLine("----------------------------");
            try
            {
                for (int i = 0; i < shop.Length + 2; i++)
                {
                    Console.WriteLine(shop[i]);//getter
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("----------------------------");
            //shop["DELL"] = new Laptop() { Model = "Mac", Price = 150_000 };//setter
            //Console.WriteLine(shop["Mac"]);
            for (int i = 0; i < shop.Length ; i++)
            {
                Console.WriteLine(shop[i]);//getter
            }
        }
    }
}