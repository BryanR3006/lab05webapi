using Lab05WebApiML.Models;
using Lab05WebApiML.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab05WebApiML.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroUsuarioController : ControllerBase
    {

        // Campo global x El Controlador
        private readonly UserManager<Persona> _user;

        public RegistroUsuarioController(UserManager<Persona> user) //Parametro 
        {
            this._user = user;
        }

        // POST api/<RegistroUsuarioController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UsuarioRegistroDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var usuario = new Persona()
            {
                Id = dto.Id,
                Email = dto.Email,
                UserName = dto.Email,
                // PasswordHash = dto.PasswordHash,
                PhoneNumber = dto.PhoneNumber,

                TipoIdentificacion = dto.TipoIdentificacion,
                NumeroIdentificacion = dto.NumeroIdentificacion,
                Nombres = dto.Nombres,
                Apellidos = dto.Apellidos,
                FechaNacimiento = dto.FechaNacimiento,
                Sexo = dto.Sexo,
                Pais = dto.Pais,
                Ciudad = dto.Ciudad,
                Direccion = dto.Direccion,
            };

            // Reglas de Negocio
            // a) Si ya existe el Usuario (Correo) no permita crearlo y retorne un Badrequest.
            // b) Que si existe un NumeroIdentificacion no permita crearlo y retorne un Badrequest 
            // c) Que si existe PhoneNumbre no permita crearlo y retorne un Badrequest
            var resultado = await _user.CreateAsync(usuario, dto.PasswordHash);

            if (!resultado.Succeeded)
            {
                return BadRequest(resultado.Errors);
            }

            return Ok(new {usuario.Id, usuario.Email});
        }

        //// GET: api/<RegistroUsuarioController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<RegistroUsuarioController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/<RegistroUsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RegistroUsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
