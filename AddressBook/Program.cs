﻿
using System;
using Address_Book;
class program
{
    public static void Main(String[] args)
    {
        AddressBook contact = new AddressBook();

        Console.WriteLine("Welcome to Address Book Project");
        bool check = true;
        while (check)
        {
            Console.WriteLine("1.Add Contact\n2.Display Contact\n3.Update Contact\n4.Delete Contact\n5.Multiple Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddContact();
                    break;
                case 2:
                    contact.Display();
                    break;
                case 3:
                    contact.Update();
                    break;
                case 4:
                    contact.Delete();
                    break;
                case 5:
                    contact.AddMultipleContacts();
                    break;
                case 0:
                    check = false;
                    break;

            }
        }


    }
}