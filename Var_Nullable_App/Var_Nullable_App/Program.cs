namespace Var_Nullable_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo of var Keyword & nullable operator (?)
            //Syntax: var variableName = initializedValue

            var number = 10; //compiler infers int
            var name = "Joe"; //compiler infers string
            var price = 10.99; //compiler infers double


            //Nullable >>> (? Operator)
            //Syntax: valueType? variableName = null

            int? age = null; //no age has been set here 
            if (age.HasValue)
            {
                Console.WriteLine($"Age: {age.Value}");
            }
            else 
            {
                Console.WriteLine("Age has not been set / there is an absence of a value");
            }

            //Print out for the var variables
                Console.WriteLine($"number: {number}, Type: {number.GetType()}");
            Console.WriteLine($"name: {name}, Type: {name.GetType()}");
            Console.WriteLine($"price: {price}, Type: {price.GetType()}");


        }
    }
}
