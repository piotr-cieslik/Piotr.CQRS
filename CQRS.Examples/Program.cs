﻿using System;

namespace CQRS.Examples
{
    public static class Program
    {
        static void Main(string[] args)
        {
            new QueryExample().Run();
            Console.ReadKey();
        }
    }
}
