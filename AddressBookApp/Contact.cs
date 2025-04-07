using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; } // Nullable type for optional email

        public override string ToString()
        {
            return $"Name: {Name}, Phone: {PhoneNumber}, Email: {Email ?? "N/A"}";
        }
    }

    class PersonalContact : Contact
    {
        public string Address { get; set; }
    }

    class BusinessContact : Contact
    {
        public string Company { get; set; }
        public string Position { get; set; }
    }


}