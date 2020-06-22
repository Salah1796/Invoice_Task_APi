using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public static class StoreExtensions
    {
        public static StoreViewModel ToViewModel(this Store model)
        {
            return new StoreViewModel
            {
               ID = model.ID,
                Name = model.Name,
               

            };
        }
        public static Store ToModel(this StoreEditViewModel editModel)
        {
            return new Store
            {
                ID = editModel.ID,

                Name=editModel.Name


            };
        }
        public static StoreEditViewModel ToEditableViewModel(this Store model)
        {
            return new StoreEditViewModel
            {
                ID = model.ID,
               Name=model.Name

            };
        }


    }
}
