using System;
public class Exhibition : Event
{
    private string _stallType;
    public string StallType
		{
			get { return _stallType; }
			set { _stallType = value; }
		}
		public Exhibition(){}
		public Exhibition(string _name, DateTime _date, string _type, string _organizer, string _stallType) : base(_name,_date,_type,_organizer) 
        {
            this._stallType=_stallType;
        }


		public  void Display()
		{
			Console.WriteLine("Event Name:" + _name);
            Console.WriteLine("Event Date: {0:dd/MM/yyyy}", _date);
            Console.WriteLine("Event Organizer:" + _organizer);
			Console.WriteLine("Event Type:"+_type);
			Console.WriteLine("Stall Type:" + _stallType);
		}
    
}