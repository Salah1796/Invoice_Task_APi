using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.Repositories
{
    public class EnitiesContext : DbContext
    {

        public EnitiesContext() : base("name=InvoiceDB")
        {
        }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<ItemUnit> ItemUnits { get; set; }
    }
}

