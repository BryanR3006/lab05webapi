namespace Lab05WebApiML.Models.DTOs
{
    public class RegisterDto
    {
        // Datos personales
        public int Id { get; set; }
        public  string? TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Sexo { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? Direccion { get; set; }

        // Datos de cuenta
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
