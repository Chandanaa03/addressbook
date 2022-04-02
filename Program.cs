using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to Address Book system------");
            
            Book addressBook = new Book();
           
            addressBook.addContacts("Chandana", "Reddy", "Nehrunagr", "Guntur", "AP", 522001, 5263893371, "chandanareshma@gmail.com");
            addressBook.print();
            Console.ReadLine();
        }
    }
}