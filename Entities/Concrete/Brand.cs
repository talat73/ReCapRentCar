
using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        //nav 
        public ICollection<Car> Cars { get; set; }

    }
}
