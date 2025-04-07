using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Generics_Demo
{
    //define MyGenericClass
    //accessSpecifier ClassName <T> {}
    public class MyGenericClass<T>
    { //this class will serve as a placeholder for parameter T    
      //add items to the generic collection instances declared below

        //define an array of type T to hold items
        private T[] items = new T[10];
        private int count = 0;
        public void AddItem(T item)
        {
            if (count < items.Length)
            {
                items[count++] = item;
            }
        }

        //method to return items in the array
        public T[] Items { get { return items; } }

        class Program
        {
            static void Main(string[] args)
            {
                //create an instance of the collection list
                List<string> names = new List<string>();
                names.Add("a");
                names.Add("b");
                names.Add("c");
                names.Add("d");

                //create an instance of the generic class with int type
                //Classname<data-type> nameofGenericCollection = new MyGenericeClass<data-type>(); 
                MyGenericClass<int> intClass = new MyGenericClass<int>();
                intClass.AddItem(1);
                intClass.AddItem(2);
                intClass.AddItem(3);
                
                //create an instance of the generic class with int type
                MyGenericClass<string> stringClass = new MyGenericClass<string>();
                stringClass.AddItem("hello");
                stringClass.AddItem("good-bye");
                stringClass.AddItem("fantastic!");

                //create an instance of the generic class with int type
                MyGenericClass<double> doubleClass = new MyGenericClass<double>();
                doubleClass.AddItem(1.0);
                doubleClass.AddItem(2.5);
                doubleClass.AddItem(15.47);

                //foreach: generic class
               

            }
        }

    }
}

//Collections - Generics
/* Allows you to define classes, interface & methods with a placeholder for datatype
 *  it willmake use of type T
 * it makes your code flexiable, reusable, type-safe 
 * generic class has a type parameter:<T>
 * this act as your placeholder for a real datatype
 * 
 * List: collection tyoe that allows fro you to store elements of a specified type in a seq order
 * use: Systems.Collections.Generics *1*
 * create an instance of List<T> class *2
 *
 */
