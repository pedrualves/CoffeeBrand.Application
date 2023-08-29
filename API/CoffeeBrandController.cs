using Domain.Entities;
using Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("[controller]")]
public class CoffeeBrandController : ControllerBase
{
    private readonly ICoffeeBrandService _coffeeBrandService;

    public CoffeeBrandController(ICoffeeBrandService coffeeBrandService)
    {
        _coffeeBrandService = coffeeBrandService;
    }

    [HttpGet("GetMultiHex")]
    public IEnumerable<CoffeeBrandModel> Get()
    {
        return _coffeeBrandService.GetCoffeeBrands();
    }

}
