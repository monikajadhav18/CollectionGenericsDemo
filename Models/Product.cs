namespace CollectionGenericsDemo.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Category { get; set; }

    public Product(int id, string name, decimal price, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Price: ₹{Price}, Category: {Category}";
    }
}