using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
       
        public int Id { get; set; }
        public int BrandId { get; set; } //MarkaId
        public int ColorId { get; set; }
        public string ModelYear  { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
