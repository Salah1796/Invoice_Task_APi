using ITI.Achitecture.Entities;
using ITI.Architecture.Repositories;
using ITI.Architecture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.Services
{
    public class ItemUnitService
    {
        UnitOfWork unitOfWork;
        Generic<ItemUnit> ItemUnitRepo;
        public ItemUnitService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            ItemUnitRepo = unitOfWork.ItemUnitRepo;
        }
        public ItemUnitEditViewModel Add(ItemUnitEditViewModel P)
        {
            ItemUnit PP = ItemUnitRepo.Add(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public ItemUnitEditViewModel Update(ItemUnitEditViewModel P)
        {
            ItemUnit PP = ItemUnitRepo.Update(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public ItemUnit GetByID(int id)
        {
            return ItemUnitRepo.GetByID(id);
        }

        public IEnumerable<ItemUnitViewModel> GetAll()
        {
            var query =
                ItemUnitRepo.GetAll();

            return query.ToList().Select(i => i.ToViewModel());
        }
        public IEnumerable<ItemUnitViewModel> GetItemUnits(int ItemID)
        {
            var query =
                ItemUnitRepo.Get(i => i.ItemID == ItemID);
            var res = query?.ToList().Select(i => i.ToViewModel()); ;
            return res;
        }

        public void Remove(int id)
        {
            ItemUnitRepo.Remove(ItemUnitRepo.GetByID(id));
            unitOfWork.Commit();
        }
    }
}
