using System.Collections.Generic;

namespace TheMall
{
    public class FoodStore : IStorable<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();

        public void AddToInventory(string foodName, FoodItem foodItem)
        {
            _inventory.Add(foodName, foodItem);
        }

        public FoodItem GetFromInventory(string inputName)
        {
            return _inventory[inputName];
        }
    }
}