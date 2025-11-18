using System;

public class Drink : MenuItem
{
    public int VolumeMl { get; private set; }
    public bool IsAlcoholic { get; private set; }

    public Drink(string name, decimal price, int volumeMl, bool isAlcoholic, string category = "Напій")
        : base(name, price, category)
    {
        VolumeMl = volumeMl;
        IsAlcoholic = isAlcoholic;
    }

    public override string GetDescription()
    {
        string alcohol = IsAlcoholic ? "з алкоголем" : "без алкоголю";
        return $"{Name} ({VolumeMl} мл, {alcohol}) - {Price} грн";
    }
}