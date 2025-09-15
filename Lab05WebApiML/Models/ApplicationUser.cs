using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05WebApiML.Models
{
       /// <summary>
       /// 
       /// </summary>
    [Table("ApplicationUser")]
    
    public class ApplicationUser : IdentityUser
    {
        public new int Id { get; set; } 

        public required string TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public  string? Nombres { get; set; }
        public  string? Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string? Sexo { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }

        // Optional
        [StringLength(100)]
        public string? Department { get; set; }

        [StringLength(50)]
        public string? EmployeeCode { get; set; }
        // Fin Optional

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLoginAt { get; set; }

        public bool IsActive { get; set; } = true;

        public int FailedLoginAttempts { get; set; } = 0;

        public DateTime? LockoutEndTime { get; set; }
        // Propiedad de navegación para roles
      public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();

     // Propiedad de navegación para refresh tokens
        //public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

        // Propiedad calculada para nombre completo
        public string FullName => $"{Nombres} {Apellidos}";


    }
}
