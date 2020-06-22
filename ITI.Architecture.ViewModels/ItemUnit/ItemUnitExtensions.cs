using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public static class ItemUnitExtensions
    {
        public static ItemUnitViewModel ToViewModel(this ItemUnit model)
        {
            return new ItemUnitViewModel
            {
                ID = model.ID,
                Item = model.Item.Name,
                ItemID = model.ItemID,
                Unit = model.Unit.Name,
                UnitID = model.UnitID,
                Price = model.Price

            };
        }
        public static ItemUnit ToModel(this ItemUnitEditViewModel editModel)
        {
            return new ItemUnit
            {
                ID = editModel.ID,
                ItemID = editModel.ItemID,
                UnitID = editModel.UnitID,
                Price = editModel.Price

            };
        }
        public static ItemUnitEditViewModel ToEditableViewModel(this ItemUnit model)
        {
            return new ItemUnitEditViewModel
            {
                ID = model.ID,
                ItemID = model.ItemID,
                UnitID = model.UnitID,
                Price = model.Price


            };
        }


    }
}
