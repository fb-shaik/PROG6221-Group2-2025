namespace Class_Struct_App
{
    //declare a class (Reference Type)
    class MyClass 
    {
        public int Value;
    }

    struct MyStruct //value type
    {
        public int Value;
    
    }
     class Program
    {
        static void Main(string[] args)
        {
            //create an object for the class
            MyClass classA = new MyClass { Value = 10 };
            //create a struct for the above MyStruct
            MyStruct structB = new MyStruct { Value = 10 };

            Console.WriteLine($"Class value before method call: {classA.Value}");
            Console.WriteLine($"Struct value before method call: {structB.Value}");

            Modify(classA, structB); //method call

            Console.WriteLine($"Class value: {classA.Value}");
            Console.WriteLine($"Struct value: {structB.Value}");
        }

        static void Modify(MyClass c, MyStruct s) 
        {
            c.Value = 20; //Changes the original as it's a reference type
            s.Value = 20; //Changes only the copy
        }
    }
}
