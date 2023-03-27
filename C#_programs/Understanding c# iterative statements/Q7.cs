using System;

class Program{ 
	
	static void Main(string[] args){
		int z = 0;
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                z = int.Parse(n.ToString()[n.ToString().Length - 1].ToString()) - int.Parse(n.ToString()[0].ToString());
                Console.WriteLine(z);
                
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
	}
}