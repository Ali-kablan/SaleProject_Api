using System.ComponentModel.DataAnnotations;

namespace SaleProject.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.CreateVersion7().ToString();

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        public string CreatedById { get; set; }
        //nvagiton to User entity is not defined in the provided code, assuming it exists in the project.
        public User CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}