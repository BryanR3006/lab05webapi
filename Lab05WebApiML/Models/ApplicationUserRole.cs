using Microsoft.AspNetCore.Identity;

namespace Lab05WebApiML.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

        public string? AssignedBy { get; set; }

        public DateTime? ExpiresAt { get; set; }

        // Propiedades de navegación
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ApplicationRole Role { get; set; } = null!;


    }
}
