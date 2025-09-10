using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05WebApiML.Models
{

    [Table("Persona")]
    public class Persona : IdentityUser
    {
        public int Id { get; set; }
        public string TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public string Direccion { get; set;}
    }
}
