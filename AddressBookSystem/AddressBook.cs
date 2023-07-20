
using System;
using System.Collections;
using System.Collections.Generic;
namespace AddressBookSystem
{
	public class AddressBook
    {
        private Dictionary<string,Contact> ContactBook = new Dictionary<string, Contact>();

       public void AddContactDetail(string firstName, Contact personDetail)
        {

            ContactBook.Add(firstName, personDetail);


        }

        
	}
}

