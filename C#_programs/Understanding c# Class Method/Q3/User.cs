using System;
class User
{
	private string _name;
	private string _username;
	private string _password;
	private long _phoneNumber;
	public User()
        {
        }
	 public User(string _name, string _username, string _password, long _phoneNumber)
        {
            this._name = _name;
            this._username = _username;
            this._password = _password;
            this._phoneNumber = _phoneNumber;
        }

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

       
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    
        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

	public bool ComparePhoneNumber(User user)
        {
            return this._phoneNumber == user._phoneNumber;
        }
}
