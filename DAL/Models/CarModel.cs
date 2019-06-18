using DAL.Models.Interfaces;

namespace DAL.Models
{
    public class CarModel : ISoftDeleteEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}