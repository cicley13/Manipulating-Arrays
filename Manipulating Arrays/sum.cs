using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Sum
    {
        public void SumMenu()
        {
            Console.Clear();
            Console.WriteLine("Select Array to get the sum and mean of");
            Console.WriteLine("1: Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("2: Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("3: Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");
            string Selection = Console.ReadLine();
            Console.Clear();

            switch (Selection)
            {
                case "1":
                    CountA();
                    Console.Clear();
                    break;

                case "2":
                    CountB();
                    Console.Clear();
                    break;

                case "3":
                    CountC();
                    Console.Clear();
                    break;
            }

            Console.ReadLine();
        }
        public void CountA()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int Sum = ArrayA.Sum();
            int Mean = Sum / ArrayA.Length;
            StringBuilder buildero = new StringBuilder();

            foreach (int i in ArrayA)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine("Array A is:"+buildero);
            
            Console.WriteLine($"Array A sum is: {Sum}");
            Console.WriteLine($"Array A mean is: {Mean}");
            Console.ReadLine();
        }

        public void CountB()
        {
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int Sum = ArrayB.Sum();
            int Mean = Sum / ArrayB.Length;
            StringBuilder buildero = new StringBuilder();

            foreach (int i in ArrayB)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine("Array A is:" + buildero);

            Console.WriteLine($"Array A sum is: {Sum}");
            Console.WriteLine($"Array A mean is: {Mean}");
            Console.ReadLine();
        }

        public void CountC()
        {
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int Sum = ArrayC.Sum();
            int Mean = Sum / ArrayC.Length;
            StringBuilder buildero = new StringBuilder();

            foreach (int i in ArrayC)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine("Array A is:" + buildero);

            Console.WriteLine($"Array A sum is: {Sum}");
            Console.WriteLine($"Array A mean is: {Mean}");
            Console.ReadLine();
        }
    }
}
