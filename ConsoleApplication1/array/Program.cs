using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter the number of rows and columns of the array");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());

            int[,] array = new int[a,b];

            try
            {
                Console.WriteLine("Enter the {0} array elements", a * b);
                for (int i = 0; i < a; i++)
                    for (int j = 0; j < b; j++)
                        array[i, j] = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
            }

            catch (System.FormatException)
            {
                Console.WriteLine("ERROR: You have entered a symbol, not a number.");
                return;
            }


            PrintArray(array, a, b);

            int minArr =  Min(array);
            Console.WriteLine();
            Console.WriteLine("The minimum element of the array is  {0}", minArr);

            int maxArr = Max(array);
            Console.WriteLine();
            Console.WriteLine("The maximum element of the array is  {0}", maxArr);

            int[,] arrayMinMax = InsertMinMax(array, a, b);
            Console.WriteLine();
            PrintArray(arrayMinMax, a, b);


            Console.ReadKey();
        }

        public static int Min(int[,] array)
        {
            int min = array[0,0];
            foreach (int el in array)
            {
                if (min > el)
                    min = el;
            }
            return min;
        }

        public static int Max(int[,] array)
        {
            int max = array[0, 0];
            foreach (int el in array)
            {
                if (max < el)
                    max = el;
            }
            return max;
        }

        public static int[,] InsertMinMax(int[,] array, int a, int b)
        {
            int iMin = 0;
            int jMin = 0;
            int iMax = 0;
            int jMax = 0;
           for (int i = 0; i < a; i++)
               for (int j = 0; j < b; j++)
               {
                   if (array[i, j] == Min(array))
                   {
                       iMin = i;
                       jMin = j;
                       break;
                   }                
               }
             

           for (int i = 0; i < a; i++)
               for (int j = 0; j < b; j++)
               {
                   if (array[i, j] == Max(array))
                   {
                       iMax = i;
                       jMax = j;
                       break;
                   }
               }    
            int tmp = array[iMin, jMin];
            array[iMin, jMin] = array[iMax, jMax];
            array[iMax, jMax] = tmp;
          
            return array;
        }

        public static void PrintArray(int[,] array, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write("{0}  ", array[i, j]);
                Console.WriteLine();
            }
        }

    }
}
