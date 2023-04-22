using System;
    public delegate void rectangleDelegate(double width, double height);
    class Program
    {
        public double height;
        public double width;

        public void PrintArea(double width, double height)
        {
            Console.WriteLine("Area is:"+height * width);
        }

        public void PrintPerimeter(double width, double height)
        {
            //fill code here
            Console.WriteLine("Perimeter is:"+2 * (height + width));
        }

        static void Main(string[] args)
        {
           double width = double.Parse(Console.ReadLine());
           double height = double.Parse(Console.ReadLine());
            Program program = new Program();
            rectangleDelegate rectangleDelegate = new rectangleDelegate(program.PrintArea);
            
            rectangleDelegate += program.PrintPerimeter;
            rectangleDelegate.Invoke(width, height);
            Console.ReadKey();
        }
    }