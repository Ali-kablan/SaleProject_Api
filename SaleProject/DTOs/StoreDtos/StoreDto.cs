using System.ComponentModel.DataAnnotations;

namespace SaleProject.DTOs.StoreDtos
{
    public class StoreDto : BaseDtos
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
