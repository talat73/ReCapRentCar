﻿using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public Car()
        {
            Rentals = new HashSet<Rentals>();
        }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        //nav
        public Brand Brand { get; set; }
        public Color Color { get; set; }

        public ICollection<Rentals> Rentals { get; set; }
    }
}
