
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

        public bool IfPersonExists(string firstName)
        {
            if (ContactBook.ContainsKey(firstName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateDetails(string firstName, string newDetail)
        {
            ContactBook[firstName].city = newDetail;

        }

        public bool DeleteContact(string firstName)
        {
            return ContactBook.Remove(firstName);

        }

        public void DisplayContactBook()
        {


            foreach(var ele in ContactBook)
            {
                Console.WriteLine($"Contact Details of {ele.Key}");
                Console.WriteLine($"First Name--> {ele.Value.firstName}");
                Console.WriteLine($"Last Name--> {ele.Value.lastName}");
                Console.WriteLine($"State Name--> {ele.Value.state}");
                Console.WriteLine($"City Name--> {ele.Value.city}");
                Console.WriteLine($"Address--> {ele.Value.address}");
                Console.WriteLine($"Email --> {ele.Value.email}");
                Console.WriteLine($"Zip Code --> {ele.Value.zipCode}");
                Console.WriteLine($"Phone Number --> {ele.Value.phoneNumber}");
            }
        }

        public void ViewContact(string firstName)
        {
            Console.WriteLine($"Contact Details of {firstName}");
            Console.WriteLine($"First Name--> {ContactBook[firstName].firstName}");
            Console.WriteLine($"First Name--> {ContactBook[firstName].lastName}");
            Console.WriteLine($"State Name--> {ContactBook[firstName].state}");
            Console.WriteLine($"City Name--> {ContactBook[firstName].city}");
            Console.WriteLine($"Address--> {ContactBook[firstName].address}");
            Console.WriteLine($"Email --> {ContactBook[firstName].email}");
            Console.WriteLine($"Zip Code --> {ContactBook[firstName].zipCode}");
            Console.WriteLine($"Phone Number --> {ContactBook[firstName].phoneNumber}");

        }

        public int GetSizeOfContactBook()
        {
            return ContactBook.Count;
        }
        

        
	}
}

