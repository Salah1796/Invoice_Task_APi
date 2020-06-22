using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.Repositories
{
    public class UnitOfWork
    {
        private EnitiesContext context;
        public Generic<Store> StoreRepo { get; set; }
        public Generic<Invoice> InvoiceRepo { get; set; }
        public Generic<Item> ItemRepo { get; set; }
        public Generic<Unit> UnitRepo { get; set; }
        public Generic<ItemUnit> ItemUnitRepo { get; set; }
        public Generic<InvoiceItem> InvoiceItemRepo { get; set; }



        public UnitOfWork(
            EnitiesContext _context,
            Generic<Store> storeRepo,
            Generic<Invoice> invoiceRepo,
            Generic<Item> itemRepo,
            Generic<Unit> unitRepo,
            Generic<ItemUnit> itemUnitRepo,
            Generic<InvoiceItem> invoiceItemRepo
            )
        {
            context = _context;
            StoreRepo = storeRepo;
            StoreRepo.Context = context;
            InvoiceRepo = invoiceRepo;
            InvoiceRepo.Context = context;
            ItemRepo = itemRepo;
            ItemRepo.Context = context;
            UnitRepo = unitRepo;
            UnitRepo.Context = context;
            ItemUnitRepo = itemUnitRepo;
            ItemUnitRepo.Context = context;
            InvoiceItemRepo = invoiceItemRepo;
            InvoiceItemRepo.Context = context;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}
