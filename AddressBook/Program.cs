using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome the program");
            Address addressBook = new Address();
            Console.WriteLine("Please Enter the Information");
            bool check = true;
            Console.WriteLine("1.Display \n 2.Edit \n");

            while (check)
            {
                Console.WriteLine("Enter The Above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the first name to edit");
                        string name = Console.ReadLine();
                        addressBook.EditAddress(name);
                        break;
                    case 0: 
                        check = false; break;
                }

            }
        }
    }
}
