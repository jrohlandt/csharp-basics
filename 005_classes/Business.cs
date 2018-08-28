using System;

namespace _005_classes
{
    public class Business
    {
        public string Name { get; set; } // this is a auto property
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        private string _twitterHandle;
        public string TwitterHandle
        {
            get 
            { 
                return _twitterHandle; 
            }

            set 
            {
                // Make sure the twitter handle starts with @
                if (value.StartsWith("@"))
                {
                    // value automatically exists in the setter.
                    _twitterHandle = value;
                }
                else 
                {
                    throw new Exception("Twitter handle must start with @ .");
                }
            }
        }

        // Constructor 
        public Business() 
        {
            Name = "Untitled Business";
        }

        // Overloaded Constructor 
        public Business(string BusinessName)
        {
            Name = BusinessName;
        }

        // Can have many overloaded constructors
        public Business(string BusinessName, string PhoneNumber)
        {
            Name = BusinessName;
            Phone = PhoneNumber;
        }

    }
}
