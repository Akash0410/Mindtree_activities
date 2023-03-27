using System;

class Program {
    public static void Main(string[] args) {
      int x,r = 0;
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());
            
            while (num > 0)
            {
                x = num % 10;
                r = r * 10 + x;
                num /= 10;
            }
            Console.WriteLine("Reverse of the number is " + r);

    }
}