using System;
using System.Net;
using System.Reflection.Emit;

namespace AddressBookSystem
{
	public class Contact
	{
		public string firstName, lastName, address, state,city, email;
		public int zipCode;
        public long phoneNumber;

		public Contact(string firstName, string lastName, string address, string state, string city, string email,int zipCode, long phoneNumber)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.address = address;
			this.state = state;
            this.city = city;
            this.email = email;
			this.zipCode = zipCode;
			this.phoneNumber = phoneNumber;
        }
		
	}
}

