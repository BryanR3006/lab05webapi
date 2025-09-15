using System.ComponentModel.DataAnnotations;

namespace Lab05WebApiML.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; } = string.Empty;

        public bool? RememberMe { get; set; } = false;

        // IP del cliente para auditoría
        public string? Clientip { get; set; }

        // User Agent para auditoría
        public string? UserAgent { get; set; }
    }
}
