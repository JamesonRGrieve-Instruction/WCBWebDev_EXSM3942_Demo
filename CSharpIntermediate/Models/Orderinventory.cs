using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    public partial class Orderinventory
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Inventoryid { get; set; }
        public int Quantity { get; set; }

        public virtual Inventoryproduct Inventory { get; set; } = null!;
        public virtual Orderinvoice Order { get; set; } = null!;
    }
}
