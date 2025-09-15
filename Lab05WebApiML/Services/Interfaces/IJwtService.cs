using Lab05WebApiML.Models.DTOs;
using Lab05WebApiML.Models;

namespace Lab05WebApiML.Services.Interfaces
{
    public interface IJwtService
    {
        Task<AuthResponseDto> GenerateJwtToken(ApplicationUser user);
        Task<AuthResponseDto> RefreshToken(string token, string refreshToken);
        Task<bool> RevokeToken(string token);
        ClaimsPrincipal ValidateToken(string token);
        string GenerateRefreshToken();
    }
}
