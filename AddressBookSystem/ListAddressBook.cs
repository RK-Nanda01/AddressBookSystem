using System;
namespace AddressBookSystem
{
	public class ListAddressBook
	{
        private Dictionary<string, AddressBook> ListOfAddressBook = new Dictionary<string, AddressBook>();

        public void addAddressBook(string nameOfAddressBook, AddressBook a)
		{
			ListOfAddressBook.Add(nameOfAddressBook, a);


		}
	}
}

