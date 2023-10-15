using System.Text;

namespace _02_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region OneArray
            /*
            int a;//  Int32 b;
            int[] myarr;  //Array
            string[] myarr1;  //Array
            float[] myarr2;  //Array
            //1
            int[] array = new int[5];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            //2
            int[] array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i * 2;
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();

            //3
            int[] array3 = new int[5] {1,2,3,4,5};
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            //4
            int[] array4 = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();
            //5
            int[] array5 = new int[5];
            for (int i = 0; i < array5.Length; i++)
            {
                Console.Write(array5[i] + " ");
            }
            Console.WriteLine();
            array5.SetValue(10, 2);
            array5.SetValue(77, 1);
            //smart pointer
           
            foreach (int elem in array5)
            {
                //elem = 1;//read only
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            //6
            int[] array6 = new int[10];
            array6 = null;
            */
            #endregion

            #region TwoArray
            /*
            int[,] arr = new int[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;

            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;
            Console.Write(arr[0, 0] +" ");
            Console.Write(arr[0, 1] + " ");
            Console.Write(arr[0, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[1, 0] + " ");
            Console.Write(arr[1, 1] + " ");
            Console.Write(arr[1, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[2, 0] + " ");
            Console.Write(arr[2, 1] + " ");
            Console.Write(arr[2, 2] + " ");
            Console.WriteLine();
            //2 
            int[,] arr2 = new int[3, 4];
            Console.WriteLine("Lenght : " + arr2.Length);

            for (int i = 0; i < arr2.GetLength(0); i++)//3
            {
                for (int j = 0; j < arr2.GetLength(1); j++)//4
                {
                    arr2[i, j] = i * j + 1;
                }
            }
            for (int i = 0; i <= arr2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= arr2.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{arr2[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ///3
            int[,] arr3 =
            {
                { 1,2,3},
                {4,5,6 },
                {7,8,9 }
            };
            Console.WriteLine(arr3.Length);
            Console.WriteLine(arr3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr3[i,j]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region _3D_Arrays
            /*
              //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
             */
            #endregion
            #region _4D_Arrays
            /*
             int[,,,] array = new int[2, 2, 2, 2];

            array[0, 0, 0, 0] = 0x0;
            array[0, 0, 0, 1] = 0x1;
            array[0, 0, 1, 0] = 0x2;
            array[0, 0, 1, 1] = 0x3;

            array[0, 1, 0, 0] = 0x4;
            array[0, 1, 0, 1] = 0x5;
            array[0, 1, 1, 0] = 0x6;
            array[0, 1, 1, 1] = 0x7;

            array[1, 0, 0, 0] = 0x8;
            array[1, 0, 0, 1] = 0x9;
            array[1, 0, 1, 0] = 0xA;
            array[1, 0, 1, 1] = 0xB;

            array[1, 1, 0, 0] = 0xC;
            array[1, 1, 0, 1] = 0xD;
            array[1, 1, 1, 0] = 0xE;
            array[1, 1, 1, 1] = 0xF;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array[i, j, k, l]);
                        }
                        Console.Write('\n');
                    }
                    Console.WriteLine();
                }
                Console.Write("\n");
            }

            //2
            int[,,,] array2 =
             {
              {
                { { 0x0, 0x1 }, {0x2, 0x3 } },
                { { 0x4, 0x5 }, {0x6, 0x7 } }
              },
              {
                { { 0x8, 0x9 }, {0xA, 0xB } },
                { { 0xC, 0xD }, {0xE, 0xF } }
              }
            };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array2[i, j, k, l]);
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            */
            #endregion
            #region ArrayMethods
            /*
            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr("Масив myArr1", myArr1);

            int[] tempArr = (int[])myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);                                // cw        
            Array.Reverse(myArr1, 5, 3);
            PrintArr("Масив myArr1 після реверсу", myArr1);
            myArr1 = tempArr;
            PrintArr("Масив myArr1 після відновлення", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Масив myArr2 до копіювання", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Масив myArr2 після копіювання", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Масив myArr2 після очистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Масив myArr2 після зміни розміру:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Невідсортований масив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Масив myArr2 після сортування: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 знаходиться в масиві на " +
                Array.BinarySearch(myArr2, 5) + " позиції");

            Console.WriteLine("Максимальный елемент в масиві myArr2: " + myArr2.Max());
            Console.WriteLine("Мінімальний елемент в масиві myArr2: " + myArr2.Min());
            Console.WriteLine("Середнє арифметичне елементів myArr2: " +
                myArr2.Average());

            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr3.Rank);
            */
            #endregion
            #region Jagged_array
            /*
              // зубчастий масив
            int[][]jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            Console.WriteLine(jagged.Length);

            // перебор с помощью цикла for
            for (int i = 0; i < jagged.Length; ++i)//3
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                   // Console.Write($"{i};{j}={     jagged[i][j]     }  ");
                    Console.Write($" {jagged[i][j]}  ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.ReadKey(); 

            foreach (int[] item in jagged)
            {
                foreach (int i in item)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
             */
            #endregion
            #region MethodsWithArray
            /*
            int[] myArray = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();
            myArray = ModifyArray(myArray, 5);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }

            Console.ReadKey();
             */
            #endregion
            #region Params
            
            int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
            double[] arr2 = new double[] { 3, 3, 3, 7, 7, 7 };
            Random rnd = new Random();  
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
                arr2[i] = Math.Round( rnd.Next(100) + rnd.NextDouble() , 2);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr2[i]);
            }
            ShowArray(10, arr);
            ShowArray(5, new int[] { 3, 3, 3, 7, 7, 7 });
            ShowArray("hello", 10, 15, 14, 47, 2, 3, 6, 9, 8, 10, 15, 14, 17);
            //int a = 5;
            //// pause
            //Console.ReadKey();
            
            #endregion
        }
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * modifier;
                //array[i] *= modifier;
            }

            return array;
        }
        static void ShowArray(int num, int[] array)
        {
            Console.WriteLine(num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void ShowArray(string str,int num, int num1, int num2,  params int[] array)
        {
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}