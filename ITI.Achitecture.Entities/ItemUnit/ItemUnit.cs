using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Achitecture.Entities
{
    [Table("ItemUnit", Schema = "dbo")]
    public class ItemUnit : BaseModel
    {
        public virtual Item Item { get; set; }
        [ForeignKey("Item")]
        [Required]
        public int ItemID { get; set; }

        public virtual Unit Unit { get; set; }
        [ForeignKey("Unit")]
        [Required]
        public int UnitID { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
