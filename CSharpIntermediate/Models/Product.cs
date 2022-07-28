using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2. Add the using statements for EF:
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpIntermediate.Models
{
    // 3. Name our table using an annotation (square brackets).
    [Table("product")]
    // 1. Change the default "internal" class to a "public" class.
    public class Product
    {
        // 5. Apply annotations for the primary key:
        [Key] // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity is Microsoft's version of AUTO_INCREMENT, EF translates this during migration.
        [Column(TypeName = "int(10)")] // Data type for the column.
        // 4. Create a property for the primary key.
        public int ID { get; set; }

        // 11. Declare any foreign key fields as properties (nothing special yet).
        [Column(TypeName = "int(10)")]
        public int CategoryID { get; set; }

        // 6. Create the rest of your columns (don't forget data types).
        [Column(TypeName = "varchar(30)")]
        public string? Name { get; set; }

        [Column(TypeName = "int(10)")]
        public int QuantityOnHand { get; set; }

        [Column(TypeName = "int(10)")]
        public int? ReorderTheshold { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal SalePrice { get; set; }

        // 12 Declare an annotation for the foreign key. I ALWAYS use nameof for these, as using literal strings makes it very easy to break during a rename.
        [ForeignKey(nameof(CategoryID))]
        // 14a. Declare the Many-to-One side of the inverse property. If you don't include at least part of the namespace here, you will
        // likely get a reference error as it thinks it's pointing to the property (ProductCategory) not the type.
        // The other side does not have this issue, as the property name is plural, but it's a decent idea to do it for symmetry anyways.
        [InverseProperty(nameof(Models.ProductCategory.Products))]
        // 13a. Declare the Many-to-One side of the navigation property.
        public virtual ProductCategory ProductCategory { get; set; }
    }
}