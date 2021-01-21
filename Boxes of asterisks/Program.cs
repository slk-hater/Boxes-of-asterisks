﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes_of_asterisks
{
    class Program
    {
        static void Main()
        {
            short numBoxes, numHeight, numWidth;
            string input;
            do
            {
                Console.Write("Insert the number of boxes to draw [1;10]: ");
                input = Console.ReadLine();
            } while (!short.TryParse(input, out numBoxes) || numBoxes < 1 || numBoxes > 10);
            do
            {
                Console.Write("Insert a height for every box [1;20]: ");
                input = Console.ReadLine();
            } while (!short.TryParse(input, out numHeight) || numHeight < 1 || numHeight > 20);
            do
            {
                Console.Write("Insert a width for every box [1;20]: ");
                input = Console.ReadLine();
            } while (!short.TryParse(input, out numWidth) || numWidth < 1 || numWidth > 20);
            for (int box = 1; box <= numBoxes; box++)
            {
                Console.WriteLine("");
                for (int h = 1; h <= numHeight; h++)
                {
                    for (int w = 1; w <= numWidth; w++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();
        }
    }
}
