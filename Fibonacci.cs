using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilanganFibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, z = 1;

            Console.Write("Masukkan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();
        }
    }
}
