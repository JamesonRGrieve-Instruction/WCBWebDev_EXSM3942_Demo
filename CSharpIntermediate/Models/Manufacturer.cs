using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpIntermediate.Models
{
    [Table("manufacturer")]
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int(10)")]
        public int ManufacturerID { get; set; }

        [Column("name", TypeName = "varchar(30)")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [InverseProperty(nameof(CSharpIntermediate.Models.Model.Manufacturer))]
        public virtual ICollection<Model> Models { get; set; }
    }
}
