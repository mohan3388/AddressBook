using System;
using AddressBookSolution;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");

        AddressBook addressBook = new AddressBook();
        addressBook.Display();

    Contact address=new Contact ();
        address.FirstName =Console.ReadLine();
        address.LastName =Console.ReadLine();
        address.Address=Console.ReadLine();
        address.State = Console.ReadLine();
        address.Email = Console.ReadLine();
        address.Zip =Convert.ToInt32(Console.ReadLine());
        address.Mobile =Convert.ToInt64 (Console.ReadLine());
        Console.WriteLine(address.FirstName+" "+ address.LastName+" "+ address.Address+" "+ address.State+" "+ address.Email+" "+ address.Zip+" "+ address.Mobile);
    }
}