using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Models.Entities
{
    public class ProductSupplier
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set;}

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }


    }
}
