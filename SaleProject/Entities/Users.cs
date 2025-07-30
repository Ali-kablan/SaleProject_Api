using System.ComponentModel.DataAnnotations;

namespace SaleProject.Entities
{
    public class User :BaseEntity
    {
       
        public string? Username { get; set; }
        public string? PasswordHash { get; set; } // Never store plain text passwords!
    }
}
