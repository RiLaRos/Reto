using Microsoft.AspNetCore.Mvc;
using UsuarioModelo;
using UsuarioNegocio;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] UsuarioRequest request)
        {
            var usuarioNegocio = new UsuariosNegocio();

            var usuarioModelo = new UsuarioModel
            {
                Nombres = request.Nombres,
                Apellidos = request.Apellidos,
                Edad = request.Edad
            };

            var response = usuarioNegocio.AgregarUsuario(usuarioModelo);
            return response;
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
