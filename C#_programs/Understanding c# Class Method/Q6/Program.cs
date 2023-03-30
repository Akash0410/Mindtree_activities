using System;

class Program
{
    static void Main(string[] args)
    {
          Stall stall = new Stall();
            Console.WriteLine("Enter the stall type");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the square feet");
            int sq_feet = int.Parse(Console.ReadLine());
            if (type == "Gold")
            {
                stall.ComputeCost(type, sq_feet);
            }
            else if(type == "Diamond")
            {
                Console.WriteLine("Enter the number of TV");
                int numTV = int.Parse(Console.ReadLine());
                stall.ComputeCost(type, sq_feet, numTV);
            }
            else
            {
                Console.WriteLine("Do you need a projector(yes/no)");
                string res = Console.ReadLine();
                bool b;
                if (res == "yes")
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
                stall.ComputeCost(type, sq_feet, b);

            }

    }

}