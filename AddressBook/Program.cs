﻿using System;
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
            Console.WriteLine("1.Display \n 2.Edit \n 3.Delete \n 4.Add data in dictionary \n 5.Edit data in dictionary");

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
                    case 3:
                        Console.WriteLine("enter first name to delete");
                        addressBook.Delete();
                        break;
                    case 4:
                        Console.WriteLine("enter name for add data dictionary");
                        string dictionaryName = Console.ReadLine();
                        addressBook.Adddict(dictionaryName);
                        break;
                    case 5:
                        Console.WriteLine("enter the name for Edit data");
                        string diname = Console.ReadLine();
                        string contName = Console.ReadLine();
                        addressBook.EditDict(diname, contName);
                        break;
                    default:
                        check = false;
                        break;
                }

            }
        }
    }
}