using System.Collections.Generic;

namespace SaleProject.Entities
{
    public class ContactInfo
    {
        public string Id { get; set; } = Guid.CreateVersion7().ToString();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
       
        //
   
    }
}
