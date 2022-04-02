using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Address Book Program");

            Book addressBook = new Book();

            AddToContacts(addressBook);
            AddToContacts(addressBook);
            Console.WriteLine("Enter FirstName of Contact to be edited");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName of Contact to be edited");
            string LastName= Console.ReadLine();
            addressBook.edit(FirstName, LastName);
            Console.ReadLine();

            addressBook.print();
            Console.ReadLine();
        }
       
        public static  void AddToContacts(Book addressBook)
        {
            Console.WriteLine("Enter FirstName");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            int Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            long PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            string Email = Console.ReadLine();
            addressBook.addContacts(FirstName, LastName, Address, City, State, Zipcode, PhoneNumber, Email);
            Console.ReadLine();

        }
    }
}
    
