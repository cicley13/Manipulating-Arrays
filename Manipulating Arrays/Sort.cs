using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Sort
    {
        public void Sorting()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.Clear();
            Console.WriteLine("Select Array to sort");
            Console.WriteLine("1: Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("2: Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("3: Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");
            string Selection = Console.ReadLine();
            Console.Clear();

            switch (Selection)
            {
                case "1":
                    Array.Sort(ArrayA);
                    foreach (int i in ArrayA) Console.Write(i + " ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "2":
                    Array.Sort(ArrayB);
                    foreach (int i in ArrayB) Console.Write(i + " ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                    Array.Sort(ArrayC);
                    foreach (int i in ArrayC) Console.Write(i + " ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
            Console.ReadLine();

        }
    }
}
