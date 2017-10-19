﻿namespace _6.RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            int[] firstRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRect = new Rectangle
            {
                Left = firstRectArgs[0],
                Top = firstRectArgs[1],
                Width = firstRectArgs[2],
                Height = firstRectArgs[3]
            };

            Rectangle secondRect = new Rectangle
            {
                Left = secondRectArgs[0],
                Top = secondRectArgs[1],
                Width = secondRectArgs[2],
                Height = secondRectArgs[3]
            };

            if (firstRect.IsInside(secondRect))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        int Right
        {
            get
            {
                return Left + Width;
            }
        }

        int CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle other)
        {
            return Top >= other.Top && Left >= other.Left
                && Bottom <= other.Bottom && Right <= other.Right;
        }
    }
}
