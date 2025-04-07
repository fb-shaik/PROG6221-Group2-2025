//Dicitionary
//Also part of the collections built-in
//Stores in key-value pairs
//Key is used to uniquely identify an item in a collection & its value is the data
//associated with that key
//using System.Collections.Generic;

//General syntax:
//Dictionary<data-type(key), data-type(value)> objectName = new Dictionary <data-type, data-type>();

//Create a dictionary to store some key-value paris
using System.Security.AccessControl;

Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("apple", 4);
dict.Add("orange", 5);
dict.Add("banana", 6);

//Calculate the total number of fruits stored in the dictionary
//make use of a foreach loop
int total = 0;

foreach (KeyValuePair<string, int> pair in dict)
    { total += pair.Value; }
    Console.WriteLine("Total number of fruits: {0}" , total);

//ContainsKey()
if (dict.ContainsKey("apple"))
{ Console.WriteLine("We have apple"); }
else
{ Console.WriteLine("We don't have apple"); }

//dict[apple]: Key behaviours as index; Access the item via the index

//dict.Remove: Call the key so we can access value & remove (removes only one item)

//Keys: returns a collection of all the keys in the dictionary
//for Loop print & display
foreach(string key in dict.Keys)
{ Console.WriteLine(key); }

//Values: returns all the values in the dictionary
foreach (int value in dict.Values)
{ Console.WriteLine(value); }

//dict.Clear();>>>Removes all items in dictionary
//dict.Count(); >>>>Return the count/ number of items in dictionary
//dict.Concat(dict); >>>>Combines multiple dictionaries 


//show both key & value
foreach (KeyValuePair<string, int> pair in dict)
{
    Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);
}


//Search based on value
int searchValue = 5;
string searchKey = dict.FirstOrDefault(x => x.Value == searchValue).Key;

if (searchKey != null)
{
    Console.WriteLine("The key for value " + searchValue + " is " + searchKey);
}
else
{
    Console.WriteLine("Value not found in dictionary.");
}



//All about Stack
//A stack is a collection of elements that can be added / removed only from one end
//which would be at the top of the stack
//Last element added to the stack is the first element to be removed (know as Last-in-First-Out>>>LIFO)

//Common Operations
//Push: to add an element
//Pop: to remove the element at the top of the stack
//Peek: can be used to retrieve the element at the top of the stack without removing it
//Count:return the number of elements in the stack
//Clear: removes all the items in the stack

//General Syntax: Stack<data-type> objectName = new Stack<data-type>();
//Create a stack to store some integers
Stack<int> stack = new Stack<int>();
stack.Push(1);//add to the stack
stack.Push(2);
stack.Push(3);

//Check what was the last element added to the stack
int topElement = stack.Peek();
Console.WriteLine(" the top element is " + topElement);

//calculate the sum of integers using while loop
int sum = 0;
while (stack.Count > 0)
    { int item = stack.Pop(); 
        sum += item;
    }
    Console.WriteLine("Sum of the integers: {0}", sum);


//All about Queue
//A collection of elements that can be added to one end (called the rear/end), and 
//remove from the other end (called the front)
//The first element added to the queue is the first to be removed; Also know as First-In-First-Out (FIFO)
//Common operations:
//Enqueue - To add elements to the end/rear
//Dequeue - To remove elements at the front of the queue
//Peek - Can also be used; Retrieve the element at the front of the queue w/o removing it
//General syntax: Queue<data-type> objectName = new Queue<data-type>();

//Create a Queue that holds string
Queue <string> queue = new Queue<string>();
queue.Enqueue("kiwi");
queue.Enqueue("star-fruit");
queue.Enqueue("dragon fruit");

//Remove first item from the queue & add it to the end & then repeat
//Print & display the updated queue




