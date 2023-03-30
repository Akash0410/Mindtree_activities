using System;

public class Program {
	public static void Main(string[] args)
	{
		 Customer customer = new Customer();
		 Console.WriteLine("Enter the customer details");
            Console.WriteLine("Enter the id :");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name :");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter the email :");
            customer.Email= Console.ReadLine();
            Console.WriteLine("Enter the address :");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Enter the purpose :");
            customer.Purpose = Console.ReadLine(); 
            Console.WriteLine("Enter the other customer details :");
            customer.OtherDetails = Console.ReadLine();
			customer.Display();
			
	}
}
