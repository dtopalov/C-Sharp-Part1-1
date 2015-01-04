using System;

class CompanyAndManager
{
    static void Main()
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter company phone number: ");
        long phoneNumber = Int64.Parse(Console.ReadLine());
        Console.WriteLine("Enter company fax number: ");
        long faxNumber = Int64.Parse(Console.ReadLine());
        Console.WriteLine("Enter website: ");
        string site = Console.ReadLine();
        Console.WriteLine("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        short age = short.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager phone number: ");
        long managerPhoneNumber = Int64.Parse(Console.ReadLine());
        Console.WriteLine("Company name: {0}\nCompany address: {1}\nCompany phone number: {2}\nCompany fax number: {3}" +
                          "\nCompany website: {4}\nManager: {5} {6}\nAge: {7}\nPhone: {8}", 
                          companyName, companyAddress, phoneNumber, faxNumber, site, 
                          firstName, lastName, age, managerPhoneNumber);
    }
}
