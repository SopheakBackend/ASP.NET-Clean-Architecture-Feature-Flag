using System.ComponentModel.DataAnnotations;

namespace LaptopApi.Application;

public class CreateLaptopDto
{
    [Required(ErrorMessage = "Brand is required.")]
    [StringLength(50, ErrorMessage = "Brand name cannot exceed 50 characters.")]
    public string Brand { get; set; } = string.Empty;

    [Required(ErrorMessage = "Model is required.")]
    [StringLength(100, ErrorMessage = "Model name cannot exceed 100 characters.")]
    public string Model { get; set; } = string.Empty;

    [Range(0.01, 10000.00, ErrorMessage = "Price must be between $0.01 and $10,000.00.")]
    public decimal BasePrice { get; set; }
}