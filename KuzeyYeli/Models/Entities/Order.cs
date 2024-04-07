using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }

        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }




    }
}
