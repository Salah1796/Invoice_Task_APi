using ITI.Architecture.Services;
using ITI.Architecture.ViewModels;
using ITI.Architecture.ViewModels.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITI.Archeticture.Presentation.Controller
{

    public class ItemUnitController : ApiController
    {
        ItemUnitService ItemUnitService;
        public ItemUnitController(ItemUnitService _ItemUnitService)
        {
            ItemUnitService = _ItemUnitService;


        }
        [HttpGet]
        public ResultViewModel<IEnumerable<ItemUnitViewModel>> GetAll()
        {
            ResultViewModel<IEnumerable<ItemUnitViewModel>> result
                 = new ResultViewModel<IEnumerable<ItemUnitViewModel>>();

            try
            {

                result.Successed = true;
                result.Data = ItemUnitService.GetAll(); ;

            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;


        }
        [HttpGet]
        public ResultViewModel<ItemUnitViewModel> GetByID(int id)
        {
            ResultViewModel<ItemUnitViewModel> result
                = new ResultViewModel<ItemUnitViewModel>();
            try
            {

                result.Successed = true;
                result.Data = ItemUnitService.GetByID(id).ToViewModel();
                if (result.Data == null)
                    result.Message = "Item Not Found !";

            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Something Went Wrong !!";
            }
            return result;
        }
        [HttpGet]
        public string Delete(int id)
        {
            if (ItemUnitService.GetByID(id) != null)
            {
                ItemUnitService.Remove(id);
                return "ItemUnit Deleted Sucessfully";
            }
            else
                return "ItemUnit Not Found !";
        }

        [HttpPost]
        public ResultViewModel<ItemUnitEditViewModel> Update(ItemUnitEditViewModel emp)
        {
            ResultViewModel<ItemUnitEditViewModel> result
                = new ResultViewModel<ItemUnitEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    ItemUnitEditViewModel selectedEmp
                        = ItemUnitService.Update(emp);

                    result.Successed = true;
                    result.Data = selectedEmp;
                }
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;
        }

        [HttpPost]
        public ResultViewModel<ItemUnitEditViewModel> Add(ItemUnitEditViewModel itemunit)
        {
            ResultViewModel<ItemUnitEditViewModel> result
                = new ResultViewModel<ItemUnitEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    if (ItemUnitService.GetAll().Where(i => i.ItemID == itemunit.ItemID && i.UnitID == itemunit.UnitID).Count() == 0)
                    {
                        ItemUnitEditViewModel selectedEmp
                       = ItemUnitService.Add(itemunit);

                        result.Successed = true;
                        result.Data = selectedEmp;

                    }
                    else
                    {
                        result.Successed = false;
                        result.Message = "This Item & Unit Already Exist !";
                    }


                }
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;
        }

        [HttpGet]
        public ResultViewModel<IEnumerable<ItemUnitViewModel>> GetItemUnits(int ItemID)
        {
            ResultViewModel<IEnumerable<ItemUnitViewModel>> result
                 = new ResultViewModel<IEnumerable<ItemUnitViewModel>>();
            try
            {

                result.Successed = true;
                result.Data = ItemUnitService.GetItemUnits(ItemID);
                if (result.Data == null)
                    result.Message = "Units Not Found !";

            }
            catch (Exception ex)
            {
                var x = ex.InnerException;

                result.Successed = false;
                result.Message = "Something Went Wrong !!";
            }
            return result;
        }
    }
}











