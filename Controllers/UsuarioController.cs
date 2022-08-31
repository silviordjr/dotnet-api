using Microsoft.AspNetCore.Mvc;
using usuario.Model;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase 

    { 
        private static List<Usuario> Usuarios() 
        {
            return new List<Usuario> {
                new Usuario {Id = 001, Nome="Silvio", Nascimento=new DateTime(1997,02,16)}
            };
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(Usuarios());
        }
    }
}