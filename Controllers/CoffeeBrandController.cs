using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeBrandController : ControllerBase
{
    private readonly ICoffeeBrandService _coffeeBrandService;

    public CoffeeBrandController(ICoffeeBrandService coffeeBrandService)
    {
        _coffeeBrandService = coffeeBrandService;
    }

    [HttpGet("GetHex")]
    public IEnumerable<CoffeeBrandModel> Get()
    {
        return _coffeeBrandService.GetCoffeeBrands();
    }

}
