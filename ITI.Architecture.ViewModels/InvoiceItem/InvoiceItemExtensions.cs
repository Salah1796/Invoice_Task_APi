using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public static class InvoiceItemExtensions
    {
        public static InvoiceItemViewModel ToViewModel(this InvoiceItem model)
        {
            return new InvoiceItemViewModel
            {
                //ID = model.ID,
                //Name = model.Person?.Name,
                //Phone = model.Person?.Phone,
                //HireDate = model.HireDate,
                //DepartmentName = model.Department?.Name,
                //Username=model.Username,
                //password=model.Password

            };
        }
        public static InvoiceItem ToModel(this InvoiceItemEditViewModel editModel)
        {
            return new InvoiceItem
            {
                ID = editModel.ID,

                TotalPrice = editModel.TotalPrice,
                Discount = editModel.Discount,
                NetPrice = editModel.NetPrice,
                InvoiceID = editModel.InvoiceID,
                ItemUnitID = editModel.ItemUnitID,
                Quantity = editModel.Quantity


            };
        }
        public static InvoiceItemEditViewModel ToEditableViewModel(this InvoiceItem model)
        {
            return new InvoiceItemEditViewModel
            {
                ID = model.ID,
                TotalPrice = model.TotalPrice,
                Discount = model.Discount,
                NetPrice = model.NetPrice,
                InvoiceID = model.InvoiceID,
                ItemUnitID = model.ItemUnitID,
                Quantity = model.Quantity
               

            };
        }


    }
}
