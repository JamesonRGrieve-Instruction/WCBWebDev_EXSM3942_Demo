using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpIntermediate.Models
{
    [Table("model")]
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int(10)")]
        public int ModelID { get; set; }

        [Column("name", TypeName = "varchar(30)")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
    }
}
