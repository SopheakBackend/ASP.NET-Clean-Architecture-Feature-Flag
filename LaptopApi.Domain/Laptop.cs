namespace LaptopApi.Domain;

public class Laptop
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
}