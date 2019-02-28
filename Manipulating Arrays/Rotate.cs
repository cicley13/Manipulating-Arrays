using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Rotate
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Select Array");
            Console.WriteLine("1: Array A: 0, 2, 4, 6, 8, 10");
            Console.WriteLine("2: Array B: 1, 3, 5, 7, 9");
            Console.WriteLine("3: Array C: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9");
            string Selection = Console.ReadLine();
            Console.Clear();

            switch (Selection)
            {
                case "1":
                    A();
                    Console.Clear();
                    break;

                case "2":
                    B();
                    Console.Clear();
                    break;

                case "3":
                    C();
                    Console.Clear();
                    break;
            }
            Console.ReadLine();
        }
        public void A()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            Console.WriteLine("Rotate the array in which direction?");
            Console.WriteLine("1: Left");
            Console.WriteLine("2: Right");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Offset left by how many?");
                    int l = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderl = new StringBuilder();

                    int[] resultl = new int[ArrayA.Length];

                    for (int i = 0; i < ArrayA.Length; i++)
                    {
                        resultl[i] = ArrayA[(i + l) % ArrayA.Length];

                        builderl.Append(resultl[i]).Append(",");
                    }
                    Console.WriteLine("Array A is: " + builderl);
                    break;

                case "2":
                    Console.WriteLine("Offset right by how many?");
                    int r = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderr = new StringBuilder();

                    int[] resultr = new int[ArrayA.Length];

                    for (int i = 0; i < ArrayA.Length; i++)
                    {
                        resultr[i] = ArrayA[(i + r) % ArrayA.Length];

                        builderr.Append(resultr[i]).Append(",");
                    }
                    Console.WriteLine("Array A is: " + builderr);
                    break;
            }
            Console.ReadLine();
        }

        public void B()
        {
            int[] Arrayb = { 1, 3, 5, 7, 9 };
            Console.WriteLine("Rotate the array in which direction?");
            Console.WriteLine("1: Left");
            Console.WriteLine("2: Right");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Offset left by how many?");
                    int l = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderl = new StringBuilder();

                    int[] resultl = new int[Arrayb.Length];

                    for (int i = 0; i < Arrayb.Length; i++)
                    {
                        resultl[i] = Arrayb[(i + l) % Arrayb.Length];

                        builderl.Append(resultl[i]).Append(",");
                    }
                    Console.WriteLine("Array B is: " + builderl);
                    break;

                case "2":
                    Console.WriteLine("Offset right by how many?");
                    int r = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderr = new StringBuilder();

                    int[] resultr = new int[Arrayb.Length];

                    for (int i = 0; i < Arrayb.Length; i++)
                    {
                        resultr[i] = Arrayb[(i + r) % Arrayb.Length];

                        builderr.Append(resultr[i]).Append(",");
                    }
                    Console.WriteLine("Array B is: " + builderr);
                    break;
            }
            Console.ReadLine();
        }


        public void C()
        {
            int[] Arrayc = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Console.WriteLine("Rotate the array in which direction?");
            Console.WriteLine("1: Left");
            Console.WriteLine("2: Right");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Offset left by how many?");
                    int l = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderl = new StringBuilder();

                    int[] resultl = new int[Arrayc.Length];

                    for (int i = 0; i < Arrayc.Length; i++)
                    {
                        resultl[i] = Arrayc[(i + l) % Arrayc.Length];

                        builderl.Append(resultl[i]).Append(",");
                    }
                    Console.WriteLine("Array C is: " + builderl);
                    break;

                case "2":
                    Console.WriteLine("Offset right by how many?");
                    int r = Convert.ToInt32(Console.ReadLine());
                    StringBuilder builderr = new StringBuilder();

                    int[] resultr = new int[Arrayc.Length];

                    for (int i = 0; i < Arrayc.Length; i++)
                    {
                        resultr[i] = Arrayc[(i + r) % Arrayc.Length];

                        builderr.Append(resultr[i]).Append(",");
                    }
                    Console.WriteLine("Array C is: " + builderr);
                    break;
            }
            Console.ReadLine();
        }


    }
}
