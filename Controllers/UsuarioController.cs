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

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);

            return Ok(usuarios);
        }
    }
}