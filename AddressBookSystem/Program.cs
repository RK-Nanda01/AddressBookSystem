using System;
using System.Net;
using System.Reflection.Emit;

namespace AddressBookSystem
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            AddressBook ContactBook = new AddressBook();
            Console.WriteLine("Welcome to Address Book Program");

            bool flag = true;
            int option;
            while(flag)
            {
                Console.WriteLine("Menu->");
                Console.WriteLine("1.Add Contact Details to the Contact Book");
                Console.WriteLine("2.Edit Contact Details");
                Console.WriteLine("0.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        {
                            flag = false;
                            break; 
                        }
                    case 1:
                        {
                            string firstName, lastName, address, state, city, email;
                            int zipCode;
                            long phoneNumber;
                            Console.WriteLine("Enter First Name");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter Address");
                            address = Console.ReadLine();
                            Console.WriteLine("Enter State");
                            state = Console.ReadLine();
                             Console.WriteLine("Enter City");
                            city = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            email = Console.ReadLine();
                            Console.WriteLine("Enter Zip Code");
                            zipCode = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Phone Number");
                            phoneNumber = Convert.ToInt64(Console.ReadLine());
                            Contact c = new Contact(firstName, lastName, address, state, city, email, zipCode, phoneNumber);
                            ContactBook.AddContactDetail(firstName, c);
                            Console.WriteLine("Successfully Added the contact");
                            break;

                        }

                    case 2:
                        {
                            string firstName;
                            Console.WriteLine("Enter First Name to edit details");
                            firstName = Console.ReadLine();
                            if(ContactBook.IfPersonExists(firstName))
                            {
                                string newCity;
                                // Only adding the ability to change City Name.//
                                // Similarly Multiple details can be changed//
                                Console.WriteLine("Enter new detail");
                                newCity = Console.ReadLine();
                                ContactBook.UpdateDetails(firstName, newCity);

                            }
                            else
                            {
                                Console.WriteLine("The person does not exist");
                            }

                            break;
                        }
                }

            }
            
           
        }
    }
}