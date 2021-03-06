using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color()
        {
            Cars = new HashSet<Car>();
        }
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        //nav 
        public ICollection<Car> Cars { get; set; }
    }
}
