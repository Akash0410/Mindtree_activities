using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name :");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Roll No :");
        int r_no = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Subject :");
        string sub = Console.ReadLine();
        Console.WriteLine("Enter Marks :");
        double marks = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Grade :");
        string grade = Console.ReadLine();
        Console.WriteLine(name + " Details :");
        Console.WriteLine("Roll No : " + r_no);
        Console.WriteLine("Subject : " + sub);
        Console.WriteLine("Marks : {0:F1}", marks);
        Console.WriteLine("Grades : " + grade);
    }
}