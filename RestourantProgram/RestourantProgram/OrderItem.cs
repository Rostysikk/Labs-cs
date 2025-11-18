using System;

public class OrderItem
{
    public IMenuItem MenuItem { get; private set; }
    public int Quantity { get; private set; }

    public OrderItem(IMenuItem menuItem, int quantity = 1)
    {
        MenuItem = menuItem;
        Quantity = quantity;
    }

    public decimal GetTotalPrice() => MenuItem.Price * Quantity;

    public override string ToString()
        => $"{MenuItem.Name} x{Quantity} - {GetTotalPrice()} грн";
}