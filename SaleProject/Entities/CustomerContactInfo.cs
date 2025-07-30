using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaleProject.Entities
{
    public class CustomerContactInfo : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? City { get; set; }

        // Foreign Key and Navigation Property back to the Customer
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
      
    }
}