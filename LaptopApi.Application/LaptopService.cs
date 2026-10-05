using LaptopApi.Domain;
using Microsoft.FeatureManagement;

namespace LaptopApi.Application;

public interface ILaptopService
{
    Task<IEnumerable<LaptopDto>> GetLaptopsAsync();
}

public class LaptopService : ILaptopService
{
    private readonly ILaptopRepository _repository;
    private readonly IFeatureManager _featureManager;

    public LaptopService(ILaptopRepository repository, IFeatureManager featureManager)
    {
        _repository = repository;
        _featureManager = featureManager;
    }

    public async Task<IEnumerable<LaptopDto>> GetLaptopsAsync()
    {
        var laptops = await _repository.GetAllAsync();
        bool enableDiscount = await _featureManager.IsEnabledAsync("EnableDiscountPrice");

        return laptops.Select(l => new LaptopDto
        {
            Id = l.Id,
            Brand = l.Brand,
            Model = l.Model,
            Price = l.BasePrice,
            DiscountedPrice = enableDiscount ? l.BasePrice * 0.90m : null
        });
    }
}