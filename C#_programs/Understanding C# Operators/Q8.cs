using System;

class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Enter the subject 1 mark");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 2 mark");
            int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 3 mark");
            int sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 4 mark");
            int sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the subject 5 mark");
            int sub5 = int.Parse(Console.ReadLine());
            int avg_sum = (sub1 + sub2 + sub3 + sub4 + sub5)/5;
            
            if (sub1 <= 2 || sub2 <= 2 || sub3 <= 2 || sub4 <= 2 || sub5 <= 2)
            {
                Console.WriteLine("No");
            }
            else if( avg_sum < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
    }
}