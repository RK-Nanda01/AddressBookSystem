
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

        public void DisplayContactBook()
        {

            foreach(var ele in ContactBook)
            {
                Console.WriteLine($"Details of {ele.Key} are as follows:");
                Console.WriteLine($"FirstName {ele.Value.firstName}");
                Console.WriteLine($"zipCode {ele.Value.zipCode}");
            }
        }
	}
}

