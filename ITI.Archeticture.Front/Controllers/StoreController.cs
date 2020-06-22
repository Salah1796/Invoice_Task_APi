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
    
    public class StoreController : ApiController
    {
        StoreService StoreService;
        public StoreController(StoreService _StoreService)
        {
            StoreService = _StoreService;
        

        }
        [HttpGet]
        public ResultViewModel<IEnumerable<StoreViewModel>> GetAll()
        {
            ResultViewModel<IEnumerable<StoreViewModel>> result
                 = new ResultViewModel<IEnumerable<StoreViewModel>>();

            try
            {
               
                    result.Successed = true;
                    result.Data = StoreService.GetAll();;
                
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;

           
        }
        [HttpGet]
        public ResultViewModel<StoreViewModel> GetByID(int id)
        {
            ResultViewModel<StoreViewModel> result
                = new ResultViewModel<StoreViewModel>();
            try
            {
                
                result.Successed = true;
                result.Data = StoreService.GetByID(id).ToViewModel();
                if (result.Data == null)
                    result.Message = "Store Not Found !";

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
            if (StoreService.GetByID(id) != null)
            {
                StoreService.Remove(id);
                return "Store Deleted Sucessfully";
            }
            else
                return "Store Not Found !";
        }

        [HttpPost]
        public ResultViewModel<StoreEditViewModel> Update(StoreEditViewModel emp)
        {
            ResultViewModel<StoreEditViewModel> result
                = new ResultViewModel<StoreEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    StoreEditViewModel selectedEmp
                        = StoreService.Update(emp);

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
        public ResultViewModel<StoreEditViewModel> Add(StoreEditViewModel emp)
        {
            ResultViewModel<StoreEditViewModel> result
                = new ResultViewModel<StoreEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Store  Name";
                }
                else
                {
                    StoreEditViewModel selectedEmp
                        = StoreService.Add(emp);
                    
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




        
    }
}










    
