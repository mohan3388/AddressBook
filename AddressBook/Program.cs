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

          Address add = new Address();
            add.Display();
        }
    }
}
