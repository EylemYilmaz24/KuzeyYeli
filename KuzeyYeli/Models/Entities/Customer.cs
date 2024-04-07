using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }

        public List<Order> OrderList { get; set;}

    }
}
