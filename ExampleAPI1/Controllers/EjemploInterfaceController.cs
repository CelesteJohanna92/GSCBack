using ExampleAPI1.EjemploDeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfaceController : ControllerBase
    {
        [HttpGet]
        public string EjemploInterface()
        {
            Perro perro = new Perro();
            return perro.Jugar();
        }
    }
}
