using System;
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
            sbyte numBoxes, numHeight, numWidth;
            string input;
            Console.Title = "Boxes of asterisks - Guilherme Fadário";
            do
            {
                Console.Write("Insert the number of boxes to draw [1;10]: ");
                input = Console.ReadLine();
            } while (!sbyte.TryParse(input, out numBoxes) || !inRange(1, 10, numBoxes));
            do
            {
                Console.Write("Insert a height for every box [1;20]: ");
                input = Console.ReadLine();
            } while (!sbyte.TryParse(input, out numHeight) || !inRange(1, 20, numHeight));
            do
            {
                Console.Write("Insert a width for every box [1;20]: ");
                input = Console.ReadLine();
            } while (!sbyte.TryParse(input, out numWidth) || !inRange(1, 20, numWidth));
            Console.WriteLine("");
            for (int box = 1; box <= numBoxes; box++)
            {
                Console.WriteLine(""); //new line for every box
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
        static bool inRange(int min, int max, int i)
        {
            if (i >= min && i <= max) return true;
            else return false;
        }
    }
}//by Gu1herme#8921
