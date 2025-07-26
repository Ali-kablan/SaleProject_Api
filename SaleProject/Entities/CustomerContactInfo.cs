using System.Collections.Generic;

namespace SaleProject.Entities
{
    public class CustomerContactInfo
    {
        public string Id { get; set; } = Guid.CreateVersion7().ToString();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }

        // Foreign Key and Navigation Property back to the Customer
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
     //  الي اديره في ال customer  دير زيه في ال   supplier 
    }
}
