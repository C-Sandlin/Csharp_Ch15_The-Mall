namespace TheMall
{
    public interface IStorable<TItem>
    {
        void AddToInventory(string name, TItem item);

        TItem GetFromInventory(string name);
    }
}