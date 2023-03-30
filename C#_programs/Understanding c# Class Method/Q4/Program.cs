using System;
class Program {
	public static void Main(string[] args) {
		 Console.WriteLine("Enter the length of the rectangle");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length,width);
            rectangle.Display();
            Console.WriteLine("Enter the new dimension");
            int dim= int.Parse(Console.ReadLine());
            
            rectangle = rectangle.DimensionChange(dim);
            rectangle.Display();

	}
}