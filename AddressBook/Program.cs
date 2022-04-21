
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
            Console.WriteLine("1.add contact\n2.display contact\n3.update contact");
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
                    check = false;
                    break;

            }
        }


    }
}