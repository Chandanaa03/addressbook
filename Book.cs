using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Book
    {
        private List<Contact> contactList;

        public Book()
        {
            contactList = new List<Contact>();
        }

        public void addContacts(string fistName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            //Create object of Contact class
            Contact contact = new Contact();
            //calling Varivale using object
            contact.FirstName = fistName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.zipcode = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            //adding contact details in contact list 
            contactList.Add(contact);
        }
        //method print
        public void print()
        {
            //using foreach loop for calling the variable 
            foreach (Contact contact in contactList)
            {
                //Prinitng the Op
                Console.WriteLine("FirstName: " + contact.FirstName);
                Console.WriteLine("LastName: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip: " + contact.zipcode);
                Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
                Console.WriteLine("Email id: " + contact.Email);
            }
        }
    }
}
