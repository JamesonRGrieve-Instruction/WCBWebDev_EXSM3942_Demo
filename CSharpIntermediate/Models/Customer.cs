using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orderinvoices = new HashSet<Orderinvoice>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;

        public virtual ICollection<Orderinvoice> Orderinvoices { get; set; }
    }
}
