using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models.Entities
{
    public class Item
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Picture { get; set; }
        public float Cost { get; set; }

    }
}
