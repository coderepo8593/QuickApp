using System.Collections.Generic;
using System.Collections.ObjectModel;
using DAL.Models.Interfaces;

namespace DAL.Models
{
    public class CarMake : ISoftDeleteEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CarModel> Models { get; set; }

        public CarMake()
        {
            Models = new Collection<CarModel>();
        }
        
        public bool IsDeleted { get; set; }
    }
}