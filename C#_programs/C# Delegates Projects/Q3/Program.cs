using System;
public delegate void NameDelegate();
    class Program
    {
        //fill code here
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name:");
            string lname = Console.ReadLine();


            Console.WriteLine("Customer Details");
            Customer customer = new Customer(fname, lname);

            NameDelegate nameDelegate = new NameDelegate(customer.DisplayFirstName);
            nameDelegate += customer.DisplayLastName;
            nameDelegate.Invoke();
            Console.ReadKey();

            //fill code here
        }

    }