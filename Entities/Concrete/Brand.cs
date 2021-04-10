﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
