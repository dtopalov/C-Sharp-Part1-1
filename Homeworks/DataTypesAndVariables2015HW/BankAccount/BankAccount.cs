//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
//3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Dimitrov";
        object holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 255.55m;
        string bankName = "Some Bank";
        string iban = "BG80BNBG96611020345678";
        string bic = "STSABGSF";
        ulong creditCardNumber1 = 123456780001111u;
        ulong creditCardNumber2 = 123456780001112u;
        ulong creditCardNumber3 = 123456780001113u;
        Console.WriteLine("Account holder: " + holderName 
            + "\nBalance: " + accountBalance 
            + " BGN\nBank: " + bankName 
            + "\nIBAN: " + iban 
            + "\nBIC: " + bic 
            + "\nCredit Card 1: " + creditCardNumber1 
            + "\nCredit Card 2: " + creditCardNumber2
            + "\nCredit Card 3: " + creditCardNumber3);
    }
}