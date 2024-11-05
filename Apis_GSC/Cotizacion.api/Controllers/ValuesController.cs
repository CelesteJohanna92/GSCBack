using Cotizacion.api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Cotizacion.api.Model;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly CotizacionService _cotizacionService;

    public ValuesController(CotizacionService cotizacionService)
    {
        _cotizacionService = cotizacionService;
    }

    [HttpPost("GetCurrencyQuote")]
    public async Task<IActionResult> GetCurrencyQuote([FromBody] Currency currency)
    {
        try
        {
            string result = await _cotizacionService.ObtenerCotizacionAsync(currency.Code);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

