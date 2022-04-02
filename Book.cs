using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Book
    {
        List<Contact> AddressList = new List<Contact>();
        Dictionary<string, List<Contact>> MultipleBook = new Dictionary<string, List<Contact>>();

        public void AddContact(Contact newcontact)
        {
            AddressList.Add(newcontact);
            MultipleBook.Add(newcontact.FirstName, AddressList);
        }
        public void Editexistingcontact()
        {
            Console.WriteLine("Enter first name of person you want to edit");
            string name = Console.ReadLine();
            foreach (var contact in AddressList)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("Enter number : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new firstname");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter new lastname");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter new zipcode");

                            long zip = Convert.ToInt64(Console.ReadLine());

                            contact.zipcode = (int)zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter new phonenumber");
                            int Number = Convert.ToInt32(Console.ReadLine());

                            contact.PhoneNumber = (int)Number;
                            break;
                        case 8:
                            Console.WriteLine("Enter new email");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void Deletecontact()
        {
            Console.WriteLine("Enter first name you want delete");
            string name = Console.ReadLine();
            Contact delete = new Contact();
            foreach (var contact in AddressList)
            {
                if (contact.FirstName == name)
                {
                    AddressList.Remove(contact);
                    Console.WriteLine(name + " contact is deleted");
                    break;
                }
            }
        }
        public void Display()
        {
            foreach (var contact in AddressList)
            {
                Console.WriteLine("\nfirstname: " + contact.FirstName + "\nlastname: " + contact.LastName + "\naddress: " + contact.Address + "\ncity: " + contact.City + "\nstate: " + contact.State + "\nzip: " + contact.zipcode + "\nphoneno: " + contact.PhoneNumber + "\nemail: " + contact.Email);
            }
        }
        public void AddUniqueContact(string uniquename)
        {
            foreach (var contact in AddressList)
            {
                if (contact.FirstName.Equals(uniquename))
                {
                    Contact multiplecontact = new Contact();

                    Console.WriteLine("Contact already exist , Enter unique name");
                    multiplecontact.FirstName = Console.ReadLine();
                    multiplecontact.LastName = Console.ReadLine();
                    multiplecontact.Address = Console.ReadLine();
                    multiplecontact.City = Console.ReadLine();
                    multiplecontact.State = Console.ReadLine();
                    multiplecontact.Email = Console.ReadLine();
                    AddContact(multiplecontact);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter firstname to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in MultipleBook)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact details of " + data.FirstName + "are : \n" + " " + data.Address + " " + data.City + " " + data.State + " " + data.zipcode + " " + data.PhoneNumber + " " + data.Email);
                    }
                }

            }

        }
        public void Search_person_city_state()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter City Name:");
                    String City = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.City == City))
                    {
                        Console.WriteLine(data.FirstName + " " + data.LastName + " is from " + data.City);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter State Name:");
                    String State = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.State == State))
                    {
                        Console.WriteLine(data.FirstName + " " + data.LastName + " is from " + data.State);
                    }
                    break;

            }


        }
    }
}
    

