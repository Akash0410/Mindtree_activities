using System;
class Account
{
    protected string _holderName;
    protected long _accountNumber;
    protected string _IFSCCode;
    protected long _contactNumber;
    
    public Account()
        {
        }

        public Account(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber)
        {
            this._holderName = _holderName;
            this._accountNumber = _accountNumber;
            this._IFSCCode = _IFSCCode;
            this._contactNumber = _contactNumber;
        }
             public string HolderName
             {
            get { return _holderName; }
            set { _holderName = value; }
             }
            public long AccountNumber
            { 
            get { return _accountNumber; } 
            set { _accountNumber = value; } 
            }
            public string IFSCCode
            {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
            }
            public long ContactNumber
            {
            get { return _contactNumber; }
            set { _contactNumber = value; }
            }

    public virtual void Display()
    {
         Console.WriteLine("Your Contact Details");
            Console.WriteLine("HolderName : " + HolderName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("IFSCCode : " + IFSCCode);
       Console.WriteLine("ContactNumber : " + ContactNumber);
    }
        
}
