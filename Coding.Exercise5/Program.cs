﻿namespace Coding.Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 3;
            switch (day)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Another day");
                        break;
                    }
            }
        }
    }
}