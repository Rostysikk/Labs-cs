using System;

public interface IMenuItem
{
    string Name { get; }
    decimal Price { get; }
    string GetDescription();
}