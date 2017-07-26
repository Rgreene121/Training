﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;



namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Using 2 arguments here!!!");
            DisplaySize(10, 20);
            WriteLine("Using 3 arguments here!!!");
            DisplaySize(1, 2, 3);
            ReadLine();
            Practice(2, "latte");
            ReadLine();
        }

        public static void DisplaySize(int length, int width, int height =1)
        {
            int area = length * width * height;
            Console.WriteLine($"The length {length} * the width{width} * the optional height of {height} = {area}");
            Console.ReadLine();

        }
        public static void Practice(double nice, string hamburger = "")
        {
            WriteLine($"We brought in the number {nice} but we need more {hamburger} for the cook out");
        }
        

    }
}
