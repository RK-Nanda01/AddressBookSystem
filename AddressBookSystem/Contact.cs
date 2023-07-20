using System;
using System.Net;
using System.Reflection.Emit;

namespace AddressBookSystem
{
	public class Contact
	{
		private string firstName, lastName, address, state,city, email;
		private int zipCode;
        private long phoneNunber;

		public Contact(string firstName, string lastName, string address, string state, string city, string email,int zipCode, long phoneNunber)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.address = address;
			this.state = state;
            this.city = city;
            this.email = email;
			this.zipCode = zipCode;
			this.phoneNunber = phoneNunber;
        }
		
	}
}

