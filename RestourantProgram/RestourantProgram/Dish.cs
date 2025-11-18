using System;

public class Dish : MenuItem
{
    public Dish(string name, decimal price, string category = "Страва")
        : base(name, price, category)
    {
    }
}