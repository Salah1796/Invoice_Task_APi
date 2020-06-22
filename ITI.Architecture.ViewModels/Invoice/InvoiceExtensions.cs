using ITI.Achitecture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Architecture.ViewModels
{
    public static class InvoiceExtensions
    {
        public static InvoiceViewModel ToViewModel(this Invoice model)
        {
            return new InvoiceViewModel
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
        public static Invoice ToModel(this InvoiceEditViewModel editModel)
        {
            return new Invoice
            {
                ID = editModel.ID,
                Number = editModel.Number,
                Date = editModel.Date,
                NetPrice = editModel.NetPrice,
                Taxes = editModel.Taxes,
                StoreID = editModel.StoreID,
                TotalPrice = editModel.TotalPrice,

            };
        }
        public static InvoiceEditViewModel ToEditableViewModel(this Invoice model)
        {
            return new InvoiceEditViewModel
            {
                ID = model.ID,
                Date = model.Date,
                NetPrice = model.NetPrice,
                TotalPrice = model.TotalPrice,
                Number = model.Number,
                Taxes = model.Taxes,
                StoreID = model.StoreID
             

            };
        }


    }
}
