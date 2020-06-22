using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public class ItemUnitViewModel
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Item { get; set; }

        public int UnitID { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }

    }
}
