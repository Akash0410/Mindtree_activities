using System;

class Program {
    public static void Main(string[] args) {
         int x, sum = 0;
            Console.WriteLine("Enter the value :");
            int val = int.Parse(Console.ReadLine());
            int y=val;
           
            while (val > 0)
            {
                x = val % 10;
                sum +=  x;
                val /= 10;
            }   
             Console.WriteLine("Sum of digits in {0} is {1}",y,sum);

    }
}