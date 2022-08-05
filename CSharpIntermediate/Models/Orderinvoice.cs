using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    public partial class Orderinvoice
    {
        public Orderinvoice()
        {
            Orderinventories = new HashSet<Orderinventory>();
        }

        public int Id { get; set; }
        public int Customerid { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Orderinventory> Orderinventories { get; set; }
    }
}
