
using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToArray();

        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < input[0]; i++)
        {
            string[] data = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ', ',', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Rectangle currentRect = new Rectangle(
                data[0], 
                int.Parse(data[1]), 
                int.Parse(data[2]), 
                int.Parse(data[3]), 
                int.Parse(data[4]));

            rectangles.Add(data[0], currentRect);
        }
        for (int i = 0; i < input[1]; i++)
        {
            var rectanglesIDs = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ', ',', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (Rectangle.isIntersect(rectangles[rectanglesIDs[0]],
                                 rectangles[rectanglesIDs[1]]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }      
        }
    }
}

