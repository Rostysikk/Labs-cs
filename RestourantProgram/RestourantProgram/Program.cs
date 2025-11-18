using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var restaurant = new Restaurant("Смачна Хата");

        restaurant.ShowMenu();

       
        var order1 = restaurant.CreateOrder(5);

        IMenuItem borscht = restaurant.FindMenuItemByName("Борщ");
        IMenuItem coffee = restaurant.FindMenuItemByName("Кава");
        IMenuItem wine = restaurant.FindMenuItemByName("Вино");

        order1.AddItem(borscht);
        order1.AddItem(coffee);
        order1.AddItem(wine, 2);

        Console.WriteLine($"Поточна сума: {order1.GetTotalPrice()} грн\n");

        order1.ChangeStatus(OrderStatus.InProgress);
        order1.ChangeStatus(OrderStatus.Ready);

        if (coffee is Drink drink)
            Console.WriteLine($"Напій: {drink.Name}, об'єм: {drink.VolumeMl} мл");

        order1.ChangeStatus(OrderStatus.Paid);


        var order2 = restaurant.CreateOrder(3);
        order2.AddItem(restaurant.FindMenuItemByName("Цезар"));
        order2.AddItem(restaurant.FindMenuItemByName("Чай"));
        order2.ChangeStatus(OrderStatus.InProgress);

        Console.WriteLine("\n=== ПІДСУМОК ===");
        restaurant.ShowAllOrders();

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}