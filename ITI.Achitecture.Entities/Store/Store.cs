using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Achitecture.Entities
{
    [Table("Store ", Schema = "dbo")]

    public class Store : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Invoice > Invoices { get; set; }
    }
}
