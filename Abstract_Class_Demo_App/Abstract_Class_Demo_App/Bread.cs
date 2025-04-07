using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Demo_App
{
    class Bread : BakedGoods
    {
        public override void Bake()
        {
            Console.WriteLine("Baking bread for 30 minutes...");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing flour, yeast, salt & water...");
        }
    }
}
