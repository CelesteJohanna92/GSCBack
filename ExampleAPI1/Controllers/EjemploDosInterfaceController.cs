using ExampleAPI1.EjemploDeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploDosInterfaceController : ControllerBase
    {
        [HttpGet]
        public string EjemploInterfaceDos()
        {
            EjemploDeInterfaz.Base _base = new Base();
            Perro perro = new Perro();
            return _base.Jugar(perro);
             
        }
    }
}
