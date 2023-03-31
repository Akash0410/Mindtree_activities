using System;
class SavingAccount : Account
{
    private double _interestRate;

		public double InterestRate
		{
			get { return _interestRate; }
			set { _interestRate = value; }
		}

    public override void Display()
    {
        base.Display();
			Console.WriteLine("Interest Rate :" + InterestRate);
		
    }
    public SavingAccount()
		{

		}
		public SavingAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, double _interestRate):base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
		{
			this._interestRate = _interestRate;

		}

    
}

