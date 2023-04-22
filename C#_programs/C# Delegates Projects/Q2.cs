using System;

    public delegate void CalculateDelegate(int num1, int num2);
    class Program
    {
        public int num1;
        public int num2;
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine("The sum is : " + (num1 + num2));
        }

        public static void Subtract(int num1, int num2)
        {

            Console.WriteLine("The subtraction  is : " + (num1 - num2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = int.Parse(Console.ReadLine());
            Program program = new Program();
            CalculateDelegate calculateDelegate = new CalculateDelegate(Addition);
            calculateDelegate += Subtract;
            calculateDelegate.Invoke(num1, num2);
           
        }
    }
