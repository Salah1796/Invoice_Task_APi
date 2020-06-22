using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public static class  UnitExtensions
    {
        public static UnitViewModel ToViewModel(this Unit model)
        {
            return new UnitViewModel
            {
                ID = model.ID,
                Name = model.Name
               

            };
        }
        public static Unit ToModel(this UnitEditViewModel editModel)
        {
            return new Unit
            {
                ID = editModel.ID,
                Name=editModel.Name


            };
        }
        public static UnitEditViewModel ToEditableViewModel(this Unit model)
        {
            return new UnitEditViewModel
            {
                ID = model.ID,
                Name=model.Name
               

            };
        }


    }
}
