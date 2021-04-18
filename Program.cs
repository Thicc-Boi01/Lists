using System;
using System.Collections.Generic;

namespace listsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            int numberi;
            int counter1 = 1;

            List<int> Numlst = new List<int>();

            while (counter1 < 6)
            {
                Console.WriteLine("Enter number " + counter1 + ":");
                numbers = Console.ReadLine();
                numberi = Convert.ToInt32(numbers);
                Numlst.Add(numberi);
                counter1++;
            }
            Console.WriteLine("Enter Another Number:");
            string x;
            int xi;

            x = Console.ReadLine();
            xi = Convert.ToInt32(x);
            if {
                List<int>.Contains(xi)
                Console.WriteLine("number allready exists.")
        }
            else



        }
    }
}


