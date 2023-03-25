 using System;
 class Program{
     static void Main(string[] args){
         Console.WriteLine("Has the player represented for India[y or n]?");
            string inp = Console.ReadLine();
            double pension = 0;
            
            if (inp == "y")
            {
                Console.WriteLine("Enter the number of Test matches he has played");
                int test_matches = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of ODI matches he has played");
                int odi_matches = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number of man of the matches he has won");
                int mofm = Convert.ToInt32(Console.ReadLine());
                
                if (test_matches>10 && odi_matches > 100)
                {
                    pension += 50000;
                }else if (test_matches > 10)
                {
                    pension += 25000;
                }else if (odi_matches > 100)
                {
                    pension += 15000;
                }
                else
                {
                    pension += 10000;
                }
                
                pension +=  mofm*0.25*pension; 
                
            }
            else if (inp == "n")
            {
                Console.WriteLine("Has he played IPL[y or n]?");
                string p_ipl = Console.ReadLine();
                if (p_ipl == "y")
                {
                    pension += 8000;
                    
                }
                else
                {
                    pension += 7000;
                   
                }
              
            }
            Console.WriteLine("Amount received as pension: Rs.{0:F1}" , pension);
     }
 }