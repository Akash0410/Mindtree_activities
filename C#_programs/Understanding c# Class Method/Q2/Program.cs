using System;
public class Program{
    public static void Main(){
        ItemType itemType = new ItemType();
            Console.WriteLine("Enter the item type name");
            itemType.Name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            itemType.CostPerDay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the deposit");
            itemType.Deposit= double.Parse(Console.ReadLine());
            itemType.Display();
    }
}