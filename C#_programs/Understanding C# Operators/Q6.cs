using System;

class Program{
    static void Main(string[] args){
            Console.WriteLine("Enter number of lost team's coins left on board");
            int points = Convert.ToInt32(Console.ReadLine());
            if (points >0 && points<=9)
            {
                Console.WriteLine("Has winning team pocketed red [y or n] ?");
                char c =Char.Parse(Console.ReadLine());
                if (c == 'y')
                {
                    points += 5;
                    Console.WriteLine("Points won : " + points);
                }else{
                    Console.WriteLine("Points won: "+points);
                }
            }else{
                Console.WriteLine("Invalid Input");
            }
            
    }
}   