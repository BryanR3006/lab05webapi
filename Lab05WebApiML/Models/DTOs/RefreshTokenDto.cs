using System.ComponentModel.DataAnnotations;

namespace Lab05WebApiML.Models.DTOs
{
    public class RefreshTokenDto
    {
        [Required(ErrorMessage = "El token es requerido")]
        public string Token { get; set; } = string.Empty;

        [Required(ErrorMessage = "El refresh token es requerido")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
