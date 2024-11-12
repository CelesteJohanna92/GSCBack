using ExampleAPI1.EjemploDeHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]
        public string GetAnimal()
        {
            Gato gato = new Gato();
            gato.Nombre = "Berlín";
            gato.Comer();
            return gato.Comer();
        }
     }
 }
    
