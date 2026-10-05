namespace LaptopApi.Domain;

public interface ILaptopRepository
{
    Task<IEnumerable<Laptop>> GetAllAsync();
}