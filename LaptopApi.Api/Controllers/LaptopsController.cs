using LaptopApi.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace LaptopApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LaptopsController : ControllerBase
{
    private readonly ILaptopService _laptopService;

    public LaptopsController(ILaptopService laptopService)
    {
        _laptopService = laptopService;
    }

    [HttpGet]
    public async Task<IActionResult> GetLaptops()
    {
        var result = await _laptopService.GetLaptopsAsync();
        return Ok(result);
    }

    [HttpGet("experimental-list")]
    [FeatureGate("EnableExperimentalList")]
    public async Task<IActionResult> GetExperimentalList()
    {
        var result = await _laptopService.GetLaptopsAsync();
        return Ok(new { Message = "Experimental endpoint accessible!", Data = result });
    }
}