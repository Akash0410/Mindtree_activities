using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
       string[] userDetails = Console.ReadLine().Split(',');
            string name = userDetails[0];
            long acc_number = long.Parse(userDetails[1]);
            string ifsc_code = userDetails[2];
            long phn_number = long.Parse(userDetails[3]);
            Console.WriteLine("Enter Account Type");
            string acc_type = Console.ReadLine();
            if (acc_type == "saving") 
            {
                Console.WriteLine("Enter Interest Rate");
                double int_rate = double.Parse(Console.ReadLine());
                SavingAccount savingAccount = new SavingAccount(name, acc_number, ifsc_code, phn_number, int_rate);               
              savingAccount.Display();
            }else if (acc_type == "current")
            {
                Console.WriteLine("Enter organization Name");
                string org_name = Console.ReadLine();
                Console.WriteLine("Enter TIN number");
                long tin = long.Parse(Console.ReadLine());
                CurrentAccount account = new CurrentAccount(name, acc_number, ifsc_code, phn_number, org_name, tin);
                account.Display();
            }
            else
            {
                Console.Write("Enter valid Account Type");
            }
    }
}

