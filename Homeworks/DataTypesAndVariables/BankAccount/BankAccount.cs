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