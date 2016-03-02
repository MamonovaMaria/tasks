using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            char[] array = { 'H', 'e', 'l', 'l', 'o', '!' };
            foreach (char el in array)
            {
               sb.Append(el);
            }
            Console.WriteLine(sb);

            sb.Replace('o', '!');
            Console.WriteLine(sb);

            sb.Remove(4, 2);
            Console.WriteLine(sb);

            sb.Insert(2, " is we");
            Console.WriteLine(sb);


            Console.ReadKey();
        }
    }
}
