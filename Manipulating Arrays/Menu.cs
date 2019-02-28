using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Menu
    {
        Sum s = new Sum();
        Rotate ro = new Rotate();
        Reverse re = new Reverse();
        Sort so = new Sort();

        public void Menuall()
        {
            Console.Clear();
            Console.WriteLine("Array options:");
            Console.WriteLine("1: Counting, summing, computing the mean arrays");
            Console.WriteLine("2: Reversing arrays");
            Console.WriteLine("3: Rotating arrays");
            Console.WriteLine("4: Sorting arrays");
            string selections=Console.ReadLine();

            switch (selections)
            {
                case "1":
                    s.SumMenu();
                    Console.Clear();
                    break;

                case "2":
                    re.ReMenu();
                    Console.Clear();
                    break;

                case "3":
                    ro.Menu();
                    Console.Clear();
                    break;

                case "4":
                    so.Sorting();
                    Console.Clear();
                    break;

            }
        }
    }
}
