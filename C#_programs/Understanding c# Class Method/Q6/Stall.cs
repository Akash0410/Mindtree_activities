using System;

class Stall
{
    public void ComputeCost(string stallType , int squareFeet)
		{
             Console.WriteLine("Gold costs Rs. "+ (squareFeet * 100));
		}
        public void ComputeCost(string stallType, int squareFeet, int numberOfTV)
        {
            int d_cost = squareFeet * 150 + numberOfTV * 100;
            Console.WriteLine("Diamond costs Rs."+d_cost);

        }
        public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability)
        {
            int p_cost = squareFeet * 200;
            if(projectorAvailability)
            {
                
                Console.WriteLine("Platinum costs Rs." +  (p_cost+ 1000));
            }
            else
            {
                Console.WriteLine("Platinum costs Rs."+ p_cost);
            }
        }

}
