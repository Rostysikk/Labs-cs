using System;
using System.Collections.Generic;
using System.Linq;

public class Restaurant
{
    public string Name { get; private set; }
    private readonly List<IMenuItem> _menu = new List<IMenuItem>();
    private readonly List<Order> _orders = new List<Order>();

    public Restaurant(string name)
    {
        Name = name;
        InitializeMenu();
    }

    private void InitializeMenu()
    {
        _menu.Add(new Dish("Борщ", 120, "Перше"));
        _menu.Add(new Dish("Котлета по-київськи", 250, "Друге"));
        _menu.Add(new Dish("Салат Цезар", 180, "Салати"));
        _menu.Add(new Drink("Кава", 60, 200, false));
        _menu.Add(new Drink("Сік апельсиновий", 70, 250, false));
        _menu.Add(new Drink("Чай зелений", 50, 300, false));
        _menu.Add(new Drink("Вино червоне", 150, 150, true));
    }

    public void ShowMenu()
    {
        Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
        for (int i = 0; i < _menu.Count; i++)
            Console.WriteLine($"{i + 1}. {_menu[i].GetDescription()}");
        Console.WriteLine("-----------------------");
    }

    public IMenuItem FindMenuItemByName(string name)
        => _menu.FirstOrDefault(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

    public Order CreateOrder(int tableNumber)
    {
        var order = new Order(tableNumber);
        _orders.Add(order);
        return order;
    }

    public Order FindOrderById(int id)
        => _orders.FirstOrDefault(o => o.Id == id);

    public void ShowAllOrders()
    {
        Console.WriteLine("--- УСІ ЗАМОВЛЕННЯ ---");
        var active = _orders.Where(o => o.Status != OrderStatus.Paid).ToList();
        if (!active.Any())
            Console.WriteLine("Немає активних замовлень.");
        else
            foreach (var o in active)
                Console.WriteLine(o + "\n");

        var paid = _orders.Where(o => o.Status == OrderStatus.Paid);
        if (paid.Any())
        {
            Console.WriteLine("Оплачені замовлення:");
            foreach (var o in paid)
                Console.WriteLine($"  [Оплачено] {o}\n");
        }
    }
}