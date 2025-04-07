using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    class AddressBook
    {
        private ArrayList contacts = new ArrayList();

        public void AddPersonalContact()
        {
            try
            {
                Console.Write("Enter personal contact name: ");
                string name = Console.ReadLine();
                Console.Write("Enter personal contact phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter personal contact email (optional): ");
                string email = Console.ReadLine();
                Console.Write("Enter personal contact address: ");
                string address = Console.ReadLine();

                PersonalContact contact = new PersonalContact { Name = name, PhoneNumber = phoneNumber, Email = email, Address = address };
                contacts.Add(contact);

                Console.WriteLine("Personal contact added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding personal contact: {ex.Message}");
            }
        }

        public void AddBusinessContact()
        {
            try
            {
                Console.Write("Enter business contact name: ");
                string name = Console.ReadLine();
                Console.Write("Enter business contact phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter business contact email (optional): ");
                string email = Console.ReadLine();
                Console.Write("Enter business contact company: ");
                string company = Console.ReadLine();
                Console.Write("Enter business contact position: ");
                string position = Console.ReadLine();

                BusinessContact contact = new BusinessContact { Name = name, PhoneNumber = phoneNumber, Email = email, Company = company, Position = position };
                contacts.Add(contact);

                Console.WriteLine("Business contact added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding business contact: {ex.Message}");
            }
        }

        public void EditContact()
        {
            try
            {
                Console.Write("Enter the name of the contact to edit: ");
                string name = Console.ReadLine();
                Contact contactToEdit = FindContactByName(name);
                if (contactToEdit != null)
                {
                    Console.WriteLine("Enter new phone number (press Enter to keep current): ");
                    string newPhoneNumber = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPhoneNumber))
                    {
                        contactToEdit.PhoneNumber = newPhoneNumber;
                    }

                    Console.WriteLine("Enter new email (press Enter to keep current): ");
                    string newEmail = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newEmail))
                    {
                        contactToEdit.Email = newEmail;
                    }

                    if (contactToEdit is PersonalContact)
                    {
                        PersonalContact personalContactToEdit = (PersonalContact)contactToEdit;
                        Console.WriteLine("Enter new address (press Enter to keep current): ");
                        string newAddress = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newAddress))
                        {
                            personalContactToEdit.Address = newAddress;
                        }
                    }
                    else if (contactToEdit is BusinessContact)
                    {
                        BusinessContact businessContactToEdit = (BusinessContact)contactToEdit;
                        Console.WriteLine("Enter new company (press Enter to keep current): ");
                        string newCompany = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newCompany))
                        {
                            businessContactToEdit.Company = newCompany;
                        }

                        Console.WriteLine("Enter new position (press Enter to keep current): ");
                        string newPosition = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newPosition))
                        {
                            businessContactToEdit.Position = newPosition;
                        }
                    }

                    Console.WriteLine("Contact edited successfully.");
                }
                else
                {
                    Console.WriteLine($"Contact with name '{name}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error editing contact: {ex.Message}");
            }
        }

        public void DeleteContact()
        {
            try
            {
                Console.Write("Enter the name of the contact to delete: ");
                string name = Console.ReadLine();
                Contact contactToDelete = FindContactByName(name);
                if (contactToDelete != null)
                {
                    contacts.Remove(contactToDelete);
                    Console.WriteLine("Contact deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Contact with name '{name}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting contact: {ex.Message}");
            }
        }

        public void SearchContact()
        {
            try
            {
                Console.Write("Enter the name of the contact to search: ");
                string name = Console.ReadLine();
                Contact contact = FindContactByName(name);
                if (contact != null)
                {
                    Console.WriteLine("Contact found:");
                    Console.WriteLine(contact);
                }
                else
                {
                    Console.WriteLine($"Contact with name '{name}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching contact: {ex.Message}");
            }
        }

        public void DisplayContacts()
        {
            try
            {
                Console.WriteLine("All Contacts:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying contacts: {ex.Message}");
            }
        }

        private Contact FindContactByName(string name)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return contact;
                }
            }
            return null;
        }
    }
}

