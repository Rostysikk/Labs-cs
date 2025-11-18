using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private static int _nextId = 100;

    public int Id { get; private set; }
    public int TableNumber { get; private set; }
    public OrderStatus Status { get; private set; } = OrderStatus.New;
    public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    public Order(int tableNumber)
    {
        Id = _nextId++;
        TableNumber = tableNumber;
        Console.WriteLine($"Створено нове замовлення для столика №{tableNumber} (ID: {Id})");
    }

    public void AddItem(IMenuItem item, int quantity = 1)
    {
        var existing = Items.FirstOrDefault(i => i.MenuItem == item);
        if (existing != null)
        {
            int index = Items.IndexOf(existing);
            Items[index] = new OrderItem(item, existing.Quantity + quantity);
        }
        else
        {
            Items.Add(new OrderItem(item, quantity));
        }
        Console.WriteLine($"Додано позицію: {item.Name}" + (quantity > 1 ? $" (x{quantity})" : ""));
    }

    public void RemoveItem(IMenuItem item)
    {
        var orderItem = Items.FirstOrDefault(i => i.MenuItem == item);
        if (orderItem != null)
        {
            Items.Remove(orderItem);
            Console.WriteLine($"Видалено позицію: {item.Name}");
        }
    }

    public decimal GetTotalPrice() => Items.Sum(i => i.GetTotalPrice());

    public void ChangeStatus(OrderStatus newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"> Змінено статус: {Status}");
    }

    public override string ToString()
    {
        string itemsList = Items.Count > 0
            ? string.Join("\n  ", Items)
            : "  (порожнє)";
        return $"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {GetTotalPrice()} грн\n{itemsList}";
    }
}