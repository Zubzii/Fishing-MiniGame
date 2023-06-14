using System;

[Serializable]
public class InventoryItem
{
    public ItemDataSO data;
    public int stacksize;

    public InventoryItem(ItemDataSO newItemData)
    {
        data = newItemData;
        AddStack();
    }

    public void AddStack() => stacksize++;
    public void RemoveStack() => stacksize--;
}
