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
    public class UnitService
    {
        UnitOfWork unitOfWork;
        Generic<Unit> UnitRepo;
        public UnitService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            UnitRepo = unitOfWork.UnitRepo;
        }
        public UnitEditViewModel Add(UnitEditViewModel P)
        {
            Unit PP = UnitRepo.Add(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public UnitEditViewModel Update(UnitEditViewModel P)
        {
            Unit PP = UnitRepo.Update(P.ToModel());
            unitOfWork.Commit();
            return PP.ToEditableViewModel();
        }
        public Unit GetByID(int id)
        {
            return UnitRepo.GetByID(id);
        }

        public IEnumerable<UnitViewModel> GetAll()
        {
            var query =
                UnitRepo.GetAll();

            return query.ToList().Select(i => i.ToViewModel());
        }

        public void Remove(int id)
        {
            UnitRepo.Remove(UnitRepo.GetByID(id));
            unitOfWork.Commit();
        }
    }
}
