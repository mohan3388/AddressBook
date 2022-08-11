using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        List<Contact> addBook = new List<Contact>();    

        public Address()
        {
            Contact contact1 = new Contact()
            {
               firstName = "mohan",
               lastName = "sahu",
               Address = "green valey",
               City = "bhilai",
               State = "cg",
               Email = "sahu@12gmail.com",
               Zip = 12451,
               Phone = 744551552
                    
            };
            Contact contact2 = new Contact()
            {
                firstName = "rajesh",
               lastName = "sah",
               Address = "green valey",
               City = "bhilai",
               State = "cg",
               Email = "sahu@12gmail.com",
               Zip = 12451,
               Phone = 744551552
            };
            Contact contact3 = new Contact()
            {
                firstName = Console.ReadLine(),
               lastName = Console.ReadLine(),
               Address = Console.ReadLine(),
               City = Console.ReadLine(),
               State = Console.ReadLine(),
               Email = Console.ReadLine(),
               Zip = Convert.ToInt32(Console.ReadLine()),
               Phone = Convert.ToInt32(Console.ReadLine()),
            };
            addBook.Add(contact1);
            addBook.Add(contact2);
            addBook.Add(contact3);
        }
        
        public void Display()
        {
            foreach(var contact in addBook)
            {
                Console.WriteLine(contact.firstName + " " + contact.lastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + contact.Zip + " " + contact.Phone);
            }
        }
        
    }
}
