using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Reverse
    {
        public void ReMenu()
        {
            Console.Clear();
            Console.WriteLine("Select Array to reverse");
            Console.WriteLine("1: Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("2: Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("3: Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");
            string Selection = Console.ReadLine();
            Console.Clear();

            switch (Selection)
            {
                case "1":
                    A1();
                    Console.Clear();
                    break;

                case "2":
                    A2();
                    Console.Clear();
                    break;

                case "3":
                    A3();
                    Console.Clear();
                    break;
            }

            Console.ReadLine();
        }
        public void A1()
        {
        int[] ArrayA = { 0, 2, 4, 6, 8, 10 };

            StringBuilder buildero = new StringBuilder();

            Console.WriteLine("Original Array A= ");
            foreach (int i in ArrayA)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine(buildero);


            Console.WriteLine("\nReversed Array A= ");
            StringBuilder builderr = new StringBuilder();
            Array.Reverse(ArrayA);

            foreach (int j in ArrayA)
            {
                builderr.Append(j).Append(",");
            }
            Console.WriteLine(builderr);
            Console.ReadLine();
        }

        public void A2()
        {

        int[] ArrayB = { 1, 3, 5, 7, 9 };

            StringBuilder buildero = new StringBuilder();

            Console.WriteLine("Original Array B= ");
            foreach (int i in ArrayB)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine(buildero);


            Console.WriteLine("\nReversed Array B= ");
            StringBuilder builderr = new StringBuilder();
            Array.Reverse(ArrayB);

            foreach (int j in ArrayB)
            {
                builderr.Append(j).Append(",");
            }
            Console.WriteLine(builderr);
            Console.ReadLine();
        }

        public void A3()
        { 
        int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

        StringBuilder buildero = new StringBuilder();

            Console.WriteLine("Original Array C= ");
            foreach (int i in ArrayC)
            {
                buildero.Append(i).Append(",");
            }
            Console.WriteLine(buildero);


            Console.WriteLine("\nReversed Array C= ");
            StringBuilder builderr = new StringBuilder();
            Array.Reverse(ArrayC);

            foreach (int j in ArrayC)
            {
                builderr.Append(j).Append(",");
            }
            Console.WriteLine(builderr);
            Console.ReadLine();
        }
    }
}
