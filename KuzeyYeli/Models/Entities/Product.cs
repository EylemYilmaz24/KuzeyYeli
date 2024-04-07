using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public List<ProductSupplier> ProductSuppliers { get; set; }

    }
}
