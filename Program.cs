﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class Program
    {
        private int[] a = new int[20];
        private int n;

        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                {
                    Console.WriteLine("\n Array dapat mempunyai maksimal 20 element. \n");

                }

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Masukan elemen pada array : ");
                Console.WriteLine("-----------------------------------");

                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" +  (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    a[1] = Int32.Parse(s1);
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
