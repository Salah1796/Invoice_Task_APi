using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public class ItemUnitEditViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        public int UnitID { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
