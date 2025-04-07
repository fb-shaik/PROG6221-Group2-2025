using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Demo_App
{//lets inherit from the abstract class called BakedGoods
    class Cake : BakedGoods
    {
        public override void Bake()
        {
            Console.WriteLine("Baking cake for 45 minutes...");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing flour, sugar, eggs, milk & butter...");
        }
    }
}
