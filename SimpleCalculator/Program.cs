﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Integer Value = {0}", userInput);
            Console.ReadLine();

        }
    }
}
