﻿using System;

class PrintLongSequence
{
    static void Main()
        {
        for (int i = 2; i <= 1000; )
        {
            Console.SetWindowSize(85, 40);
            Console.BufferHeight = 1000;
            Console.WriteLine(i++);
            Console.WriteLine(-i++);
        }
    }
}

