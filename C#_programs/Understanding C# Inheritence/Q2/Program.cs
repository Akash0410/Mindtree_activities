using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Event Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Event Date:");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine("Enter the Event Organizer:");
        string organiser = Console.ReadLine();
        Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
        string eType = Console.ReadLine();

		if(eType == "Exhibition")
		{
			Console.WriteLine("Enter the Stall Type:");
			string s_type = Console.ReadLine();
			Exhibition exibition = new Exhibition(name,date,eType,organiser,s_type);
			exibition.Display();
		}
		else if(eType == "Stage Event")
		{
			Console.WriteLine("Enter the Show Type:");
			string show_type = Console.ReadLine();
			StageEvent stageEvent = new StageEvent(name,date,eType,organiser,show_type);
			stageEvent.Display();
			
		}
		else
		{
			Console.WriteLine("Enter the correct Event Type and try again...");
		}
    }
}
