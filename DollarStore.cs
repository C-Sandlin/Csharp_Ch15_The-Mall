using System.Collections.Generic;

namespace TheMall
{
    public class DollarStore : IStorable<DollarItem>
    {
        public string Name { get; set; }
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        public void AddToInventory(string dollarName, DollarItem dollarItem)
        {
            _inventory.Add(dollarName, dollarItem);
        }

        public DollarItem GetFromInventory(string inputName)
        {
            return _inventory[inputName];
        }
    }
}