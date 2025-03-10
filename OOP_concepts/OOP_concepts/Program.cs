using System.Reflection.Metadata.Ecma335;

namespace OOP_concepts
{
    //accessSpecifier class ClassName
    //{
    //      attributes
    //      methods()
    //}
    public class Person 
    { //attributes - characteristic
        /*
         * public string Name 
                {
                    get { return name; }
                    set { name = value; }
                }
        */
        public string Name { get; set; } //auto properties
        public int Age { get; set; }

        //methods - things the class can do
        public virtual void Greet() 
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years");
        }
    
    }

    //In Java: childClassName inherits parentClassName{}
    //In C#: childClassName : parentClassName{}
    public class Student : Person
    {
        //unique to the child class as an attribute
        public string Grade { get; set; }

        public override void Greet() 
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years and I am in grade {Grade}.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClassName objName = new ClassPerson();
            Person person1 = new Person(); //created an object called 'person1'
            //set the attribute values for the object created above
            //objName.attribute = assigned value;
            person1.Name = "Alice";
            person1.Age= 20;

            //call a method that is associated to the object through the class blueprint
            person1.Greet();

            //create a child object
            Student student1 = new Student();
            student1.Name = "Charlie";
            student1.Age = 4;
            student1.Grade = "000";

            //invoke a method 
            student1.Greet();



        }
    }
}
