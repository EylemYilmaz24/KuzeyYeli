using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Entities
{
    public class Shipper
    {


        public int ID { get; set; }

        public string ShipperName { get; set; }
        public string ShipperDescription { get; set;}
        public DateTime ShipTime { get; set; }

        public List<Order> OrderList { get; set; }

    }
}
