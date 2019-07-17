using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColorPen = new DollarItem()
            {
                Name = "Multi Colored Pen with 12 Colors"
            };

            Dollarama.AddToInventory("mcp", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();

            FoodItem CaramelPecanBun = new FoodItem()
            {
                Name = "Caramel Pecan Bun",
                Price = 3.50,
                Calories = 1080
            };

            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "Classic Roll",
                Price = 1.50,
                Calories = 8800
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cpb", CaramelPecanBun);

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("cpb").Name);
        }
    }
}
