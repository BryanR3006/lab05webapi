namespace Lab05WebApiML.Models.DTOs
{
    public class UserInfoDto
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Department { get; set; }
        public string? EmployeeCode { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; }
    }
}
