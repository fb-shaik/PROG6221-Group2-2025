namespace Abstract_Class_Demo_App
{
    class Program
    {
        static void Main(string[] args)
        {
           //create an object for each of the child class
           //Syntax: abstractClassName objectName = new childClassConstructormethod();
            //invoke the methods associated to the class
           
            //Baking bread
            BakedGoods bread = new Bread();
            bread.PreheatOven(); //this will call the method from the abstract class
            bread.MixIngredients(); // this will call the unique method implementation from the child class
            bread.Bake();// this will call the unique method implementation from the child class

            Console.WriteLine();

            //Baking cake
            BakedGoods cake = new Cake();
            cake.PreheatOven();
            cake.MixIngredients();
            cake.Bake();

        }
    }
}
/*
    Abstract Class
- Code Reusability: Sharing the foundation across many child classes
- Blueprint that can include method implementations
- No multi-inheritance 
- A class can only inherit from one abstract class

 
 
 
 */