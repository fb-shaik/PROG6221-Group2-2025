using System.Collections;

namespace Non_Generic_Generic_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //example of non-generic collection
            //syntax: ArrayList nameOfArrayList = new ArrayList(); 
            ArrayList arrayList = new ArrayList();//dynamic array & can hold any data type

            //adding elements to the ArrayList
            arrayList.Add("Apple");
            arrayList.Add("Peach");
            arrayList.Add("Orange");

            //access elements within the ArrayList
            Console.WriteLine("Array List elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Remove an element from the list");
            arrayList.Remove("Apple");

            //access elements within the ArrayList
            Console.WriteLine("Array List elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //HashTable - a collection of key-value pairs
            // each key is unique
            //syntax: Hashtable hashName = new Hashtable();

            //create a hastable for employees
            Hashtable employees = new Hashtable();

            //Add in the key-value pairs
            //Syntax: hashName.Add(key, value);
            employees.Add(101, "Alice");
            employees.Add(102, "Bob");
            employees.Add(103, "Joe");

            //accessing values
            Console.WriteLine($"Employee 101: {employees[101]}");

            //check if a key exists
            if (employees.ContainsKey(102))
            {
                Console.WriteLine("Employee 102 exists!");
            }
               
        }
    }
}
/* Collections in C#
 * Two types of collections
 * 1. Non-Generic
 * store elements as object type
 * this means they can hold any data-type 
 * Boxing & UnBoxing Issues related to value types & reference types
 * Increased memory usage
 *e.g. ArrayList is non-generic collection 
 * There is no type-safety ( can store mixed datatypes)
 * A lot slower in performance (boxing/unboxing issue)
 * Less clear readability >>> typecasting
 * More error prone
 */