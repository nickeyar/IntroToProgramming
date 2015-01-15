using System;

class PrintASequence
    {
        static void Main()
        {
           for (int i = 2; i <= 100;)
           {
               Console.WriteLine(i++);
               Console.WriteLine(-i++);
           }
        }
    }