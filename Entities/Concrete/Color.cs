using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
