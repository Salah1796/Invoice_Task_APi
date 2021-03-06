﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public class InvoiceItemEditViewModel
    {

        [Required]

        public int ID { get; set; }
        [Required]

        public int InvoiceID { get; set; }
        [Required]
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
