using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Achitecture.Entities
{
    [Table("Invoice Item", Schema = "dbo")]
    public class InvoiceItem : BaseModel
    {
        public virtual Invoice Invoice { get; set; }
        [Required]
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }


        public virtual ItemUnit ItemUnit { get; set; }

        [Required]
        [ForeignKey("ItemUnit")]
        public int ItemUnitID { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]

        public double TotalPrice { get; set; }

         [Required]
        public decimal Discount { get; set; }
        [Required]

        public double NetPrice { get; set; }







    }
}
