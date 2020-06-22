using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public class StoreEditViewModel
    {

        [Required]

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
