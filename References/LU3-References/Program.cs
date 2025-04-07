//Two kinds of types are found in C#
//Reference & Value
//Differ in how data is stored & manipulated

//Reference type in C#
//A Reference type is a type that store a reference to an object in memory
//rather than the object itself

//Reference types seen so far: Classes, Arrays, Delegate
//Explore: Delegate

//Value Type:
// Stores the actual data value directly in memory
//Primitive (int, float, bool, enums)

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = a; //Creates a copy of a
        b = 10;
        Console.WriteLine(a); //5
        Console.WriteLine(b);//10

        //In contrast the reference type behaviours differently
        //it stores/refers to an object in memory rather than the object itself

        int[] c = new int[] { 1, 2, 3 };
        int[] d = c; //Copies the reference of what is in []c
        Console.WriteLine(c[0]); //Output: 1
        Console.WriteLine(d[0]); //Output: 1

        //create an instance of the above delegate
        MyDelegate myDelegate = new MyDelegate(PrintMessage);

        //call the delegate, which will invoke the above PrintMessage
        myDelegate("Hello World");

    }
    //Delegates
    //A delegate is an object that represents a method or collection of methods
    //Allow you to pass methods a parameters to other methods
    //Allow to store methods in collections & invoke them dynamically at runtime 
    //Useful for event-driven programming; have a respond to events by calling
    //one or more methods that are registered to handle the event

    //Steps to create a delegate
    //First define a delegate type that specifies the signature of method/methods
    //it can represent
    //keyword: delegate
    //Signature includes: Method's return type, name, parameter types

    //declare a delegate type
    public delegate void MyDelegate(string message);

    static void PrintMessage(string message)
{ 
    Console.WriteLine(message);
}

}






