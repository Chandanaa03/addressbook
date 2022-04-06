using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            Book addressBook = new Book();

            Contact newcontact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Delete contact \n5. Add contact \n6. Add multiple Address Book with unique name \n7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
              
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information FirstName, LastName, Address,City, State, zipcode, PhoneNumber , Email ");
                        newcontact.FirstName = Console.ReadLine();
                        newcontact.LastName = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.City = Console.ReadLine();
                        newcontact.State = Console.ReadLine();
                        newcontact.Email = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information FirstName, LastName, Address,City, State, zipcode, PhoneNumber and Email");
                        newcontact.FirstName = Console.ReadLine();
                        newcontact.LastName = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.City = Console.ReadLine();
                        newcontact.State = Console.ReadLine();
                        newcontact.Email = Console.ReadLine();
                        addressBook.AddContact(newcontact);
                        addressBook.Display();
                        break;
                    case 3:
                        addressBook.Editexistingcontact();
                        addressBook.Display();
                        break;
                    case 4:
                        addressBook.Deletecontact();
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information FirstName, LastName, Address,City, State, zipcode, PhoneNumber and Email");
                        newcontact.FirstName = Console.ReadLine();
                        newcontact.LastName = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.City = Console.ReadLine();
                        newcontact.State = Console.ReadLine();
                        newcontact.Email = Console.ReadLine();
                        addressBook.AddContact(newcontact);
                        addressBook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string name = Console.ReadLine();
                        addressBook.AddUniqueContact(name);
                        addressBook.DisplayUniqueContacts();

                        break;
                    case 7:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string duplicatename = Console.ReadLine();
                        addressBook.AddUniqueContact(duplicatename);
                        addressBook.DisplayUniqueContacts();
                        break;
                    case 8:
                        addressBook.Search_person_city_state();

                        break;
                    case 9:
                        addressBook.view_person_city_state();
                        break;
                    case 10:
                        addressBook.Count_person_city_state();
                        break;
                    case 11:
                        addressBook.SortbyName();
                        break;
                    case 12:
                        addressBook.sortbystate();
                        break;
                    case 13:
                        addressBook.sortbycity();
                        break;
                    case 14:
                        flag = false;
                        break;

                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}


