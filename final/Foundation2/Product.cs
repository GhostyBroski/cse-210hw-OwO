using System;

public class Product
{
    private string name;
    private string id;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, string id, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.id = id;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost() => pricePerUnit * quantity;
    public string GetName() => name;
    public string GetId() => id;
    public decimal GetPricePerUnit() => pricePerUnit;
    public int GetQuantity() => quantity;
}