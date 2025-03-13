using Poo_Exercises;

string firstName = "Tim";
string lastName = "Shao";

BankCustomer customer1 = new BankCustomer();

firstName = "Lisa";
BankCustomer customer2 = new BankCustomer(firstName, "Shao");

firstName = "Sandy";
lastName = "zoeng";
BankCustomer customer3 = new BankCustomer(firstName, lastName);

Console.WriteLine($"BankCustomer 1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");
Console.WriteLine($"BankCustomer 2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerId}");
Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");
