using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Achitecture.Entities
{
    [Table("Invoice ", Schema = "dbo")]
    public class Invoice : BaseModel
    {

        public virtual Store Store { get; set; }
        [Required]
        [ForeignKey("Store")]
        public int StoreID { get; set; }


        [Required]
        [MaxLength(250)]
        public string Number { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]

        public double TotalPrice { get; set; }
        [Required]

        public decimal Taxes { get; set; }
        [Required]

        public double NetPrice { get; set; }

        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
