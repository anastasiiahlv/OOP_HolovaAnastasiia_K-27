using System;
// Завдання 1: Принцип єдиного обов’язку (SRP) (The Single Responsibility Principle)
class Item
{
}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void CalculateTotalSum() {/*...*/}
}

class ShowItems
{
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
}

class ShowOrders
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}

class ManageItem
{
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}

class ManageOrder
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}


