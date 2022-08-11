using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {


        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Contact Details: ");

            Contact address = new Contact();
            {
                address.FirstName = Console.ReadLine();
                address.LastName = Console.ReadLine();
                address.Address = Console.ReadLine();
                address.City = Console.ReadLine();
                address.State = Console.ReadLine();
                address.Zip = Convert.ToInt32(Console.ReadLine());
                address.Mobile = Convert.ToInt64(Console.ReadLine());
                address.Email = Console.ReadLine();

                Console.WriteLine(address.FirstName + " " + address.LastName + " " + address.Address + " " + address.City + " " + address.State + " " + address.Zip + " " + address.Mobile + " " + address.Email);
            }
            
        }
    }
}
