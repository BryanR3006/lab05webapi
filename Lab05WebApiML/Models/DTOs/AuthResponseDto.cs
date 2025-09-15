namespace Lab05WebApiML.Models.DTOs
{
    public class AuthResponseDto
    {
        public bool IsAuthenticated { get; set; }
        public string? Message { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? TokenExpiration { get; set; }
        public UserInfoDto? User { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
