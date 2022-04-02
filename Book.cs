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

        public void addContacts(string FirstName, string LastName, string Address, string City, string State, int zipcode, long PhoneNumber, string Email)
        {
            
            Contact contact = new Contact();
            
            contact.FirstName = FirstName;
            contact.LastName = LastName;
            contact.Address = Address;
            contact.City = City;
            contact.State = State;
            contact.zipcode = zipcode;
            contact.PhoneNumber = PhoneNumber;
            contact.Email = Email;
            
            contactList.Add(contact);
        }
       
        public void print()
        {
           
            foreach (Contact contact in contactList)
            {
               
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
