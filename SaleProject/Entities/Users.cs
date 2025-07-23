using System.ComponentModel.DataAnnotations;

namespace SaleProject.Entities
{
    public class User
    {
        [Required]
        public string Id { get; set; }  =  Guid.CreateVersion7().ToString();
        public string? Username { get; set; }
        public string? PasswordHash { get; set; } 
    }
}
