using LaptopApi.Domain;

namespace LaptopApi.Infrastructure;

public class InMemoryLaptopRepository : ILaptopRepository
{
    private readonly List<Laptop> _laptops = new()
    {
        new Laptop { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Brand = "Apple", Model = "MacBook Pro M3", BasePrice = 1999.99m },
        new Laptop { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Brand = "Dell", Model = "XPS 15", BasePrice = 1499.99m },
        new Laptop { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Brand = "Lenovo", Model = "ThinkPad X1 Carbon", BasePrice = 1299.99m }
    };

    public Task<IEnumerable<Laptop>> GetAllAsync() => Task.FromResult<IEnumerable<Laptop>>(_laptops);
}