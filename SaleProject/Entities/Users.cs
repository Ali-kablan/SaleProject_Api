using System.ComponentModel.DataAnnotations;

namespace SaleProject.Entities
{
    public class User :BaseEntity
    {
       
        public required string Username { get; set; }
        public required string PasswordHash { get; set; } // Never store plain text passwords!
    }
}
