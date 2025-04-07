using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Demo_App
{
   abstract class BakedGoods
    {
        //3 methods
        //( 1 method concrete (implementation)
        // 2 methods abstract in behaviour ( has no method body)

        //concrete method - A shared method 
        //All baked goods pre-heat the oven the same way
        public void PreheatOven() 
        {
            Console.WriteLine("Pre-heating oven to 180 degree...");
        }

        //Abstract methods - each version of this method will have a unique implementation
        //Every baked good has its own way of mixing & baking
        public abstract void MixIngredients();
        public abstract void Bake();

        //Syntax for abstract method:
        // accessSpecifier abstract returnType MethodName();
        // there is no {} after the method name as there is no associated method body
    
    }
}
