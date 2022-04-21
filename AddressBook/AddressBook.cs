using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace AddressBookSolution
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                Mobile = Convert.ToInt64(Console.ReadLine())
            };
            Contact address2 = new Contact()
            {
                FirstName = "mohan",
                LastName = "sahu",
                Address = "green valley",
                State = "bhilai",
                Email = "sahu@12gmail",
                Zip = 452014,
                Mobile = 789852487,
            };
            Contact address3 = new Contact()
            {
                FirstName = "rajesh",
                LastName = "saha",
                Address = "green valley",
                State = "bhilai",
                Email = "dsas@gmail",
                Zip = 452014,
                Mobile = 789852487,
            };
            addressBook.Add(address1);
            addressBook.Add(address2);
            addressBook.Add(address3);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Mobile);
            }
        }

    }
}