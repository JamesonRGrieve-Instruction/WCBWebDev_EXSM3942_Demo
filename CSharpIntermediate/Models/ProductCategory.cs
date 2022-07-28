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
    [Table("product_category")]
    // 1. Change the default "internal" class to a "public" class.
    public class ProductCategory
    {
        // 5. Apply annotations for the primary key:
        [Key] // PRIMARY KEY
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity is Microsoft's version of AUTO_INCREMENT, EF translates this during migration.
        [Column(TypeName = "int(10)")] // Data type for the column.
        // 4. Create a property for the primary key.
        public int ID { get; set; }

        // 6. Create the rest of your columns (don't forget data types).
        [Column(TypeName = "varchar(30)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Description { get; set; }
        // 14b. Declare the One-to-Many side of the inverse property.
        [InverseProperty(nameof(Models.Product.ProductCategory))]
        // 13b. Declare the One-to-Many side of the navigation property.
        public virtual ICollection<Product> Products { get; set; }  
    }
}