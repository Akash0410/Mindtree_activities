using System;
public class ItemType{
    private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private double _costPerDay;

		public double CostPerDay
		{
			get { return _costPerDay; }
			set { _costPerDay = value; }
		}
		private double _deposit;

		public double Deposit
		{
			get { return _deposit; }
			set { _deposit = value; }
		}


    public void Display() {
        
			Console.WriteLine("Item type details");
			Console.WriteLine("Name:" + Name);
			Console.WriteLine("CostPerDay:{0:F2}", CostPerDay);
			Console.WriteLine("Deposit:{0:F2}", Deposit);
    }
}