using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Achitecture.Entities
{
    [Table("Unit", Schema = "dbo")]
    public class Unit : BaseModel
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

     
        public virtual ICollection<ItemUnit> ItemUnits { get; set; }
       
    }
}
