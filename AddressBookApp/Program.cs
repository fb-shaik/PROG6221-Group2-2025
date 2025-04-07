using System;

namespace AddressBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                try
                {
                    Console.WriteLine("Address Book Menu:");
                    Console.WriteLine("1. Add Personal Contact");
                    Console.WriteLine("2. Add Business Contact");
                    Console.WriteLine("3. Edit Contact");
                    Console.WriteLine("4. Delete Contact");
                    Console.WriteLine("5. Search Contact");
                    Console.WriteLine("6. Display All Contacts");
                    Console.WriteLine("7. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            addressBook.AddPersonalContact();
                            break;
                        case 2:
                            addressBook.AddBusinessContact();
                            break;
                        case 3:
                            addressBook.EditContact();
                            break;
                        case 4:
                            addressBook.DeleteContact();
                            break;
                        case 5:
                            addressBook.SearchContact();
                            break;
                        case 6:
                            addressBook.DisplayContacts();
                            break;
                        case 7:
                            Console.WriteLine("Exiting...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
