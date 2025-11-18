using System;

public abstract class MenuItem : IMenuItem
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public string Category { get; private set; }

    protected MenuItem(string name, decimal price, string category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public virtual string GetDescription()
        => $"{Name} ({Category}) - {Price} грн";
}