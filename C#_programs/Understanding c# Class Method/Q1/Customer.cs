using System;
class Customer
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _purpose;

        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }

        private string _otherDetails;

        public string OtherDetails
        {
            get { return _otherDetails; }
            set { _otherDetails = value; }
        }

        internal void Display()
        {
           Console.WriteLine("Customer details are :");
            Console.WriteLine("ID :"+Id);
            Console.WriteLine("Name :"+Name);
            Console.WriteLine("Email :"+Email);
            Console.WriteLine("Address :"+Address);
            Console.WriteLine("Purpose :"+Purpose);
            Console.WriteLine("Other details :"+OtherDetails);
        }
    }

