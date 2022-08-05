using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    public partial class Inventoryproduct
    {
        public Inventoryproduct()
        {
            Orderinventories = new HashSet<Orderinventory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Qoh { get; set; }

        public virtual ICollection<Orderinventory> Orderinventories { get; set; }
    }
}
