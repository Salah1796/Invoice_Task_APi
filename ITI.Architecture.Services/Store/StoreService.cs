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
    public class StoreService
    {
        UnitOfWork unitOfWork;
        Generic<Store> StoreRepo;
        public StoreService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            StoreRepo = unitOfWork.StoreRepo;
        }
        public StoreEditViewModel Add(StoreEditViewModel P)
        {
            Store PP = StoreRepo.Add(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public StoreEditViewModel Update(StoreEditViewModel P)
        {
            Store PP = StoreRepo.Update(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public Store GetByID(int id)
        {
            return StoreRepo.GetByID(id);
        }

        public IEnumerable<StoreViewModel> GetAll()
        {
            var query =
                StoreRepo.GetAll();

            return query.ToList().Select(i => i.ToViewModel());
        }
        public void Remove(int id)
        {
            StoreRepo.Remove(StoreRepo.GetByID(id));
            unitOfWork.Commit();
        }
    }
}
