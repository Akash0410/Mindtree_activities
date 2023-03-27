using System;
class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            for (int i=n; i>=0; i--)
            {
                for (int j = 1;  j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
