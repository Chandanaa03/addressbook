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
        public void edit(string firstName, string lastName)
        {
           
            Contact contactToBeEdited = null;

            
            foreach (Contact contact in this.contactList)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                    contactToBeEdited = contact;
            }
           
            if (contactToBeEdited == null)
            {
                
                Console.WriteLine("No such contact exists");
                return;
            }
           
            this.editThisContact(contactToBeEdited);
        }
        public void editThisContact(Contact contactToBeEdited)
        {
           
            while (true)
            {
               
                Console.WriteLine("Enter 1 to edit FirstName");
                Console.WriteLine("Enter 2 to edit LastName");
                Console.WriteLine("Enter 3 to edit Address");
                Console.WriteLine("Enter 4 to edit City");
                Console.WriteLine("Enter 5 to edit State");
                Console.WriteLine("Enter 6 to edit Zip");
                Console.WriteLine("Enter 7 to edit PhoneNumber");
                Console.WriteLine("Enter 8 to edit Email Id");
                Console.WriteLine("Enter 9 if Editing is done");
                
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice)
                {
                  
                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string fName = Console.ReadLine();
                        contactToBeEdited.FirstName = fName;
                        break;
                   
                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lName = Console.ReadLine();
                        contactToBeEdited.LastName = lName;
                        break;
                  
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactToBeEdited.Address = address;
                        break;
                   
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactToBeEdited.City = city;
                        break;
                  
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactToBeEdited.State = state;
                        break;
                    
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contactToBeEdited.zipcode = zip;
                        break;
                    
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        contactToBeEdited.PhoneNumber = phoneNumber;
                        break;
                   
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactToBeEdited.Email = email;
                        break;
                   
                    case 9:
                        Console.WriteLine("Editing done.New Contact :-");
                        this.printSpecificContact(contactToBeEdited);
                        return;
                }
            }
        }
       
        public void printSpecificContact(Contact contact)
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
    