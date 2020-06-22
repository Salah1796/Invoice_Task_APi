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
    
    public class UnitController : ApiController
    {
        UnitService UnitService;
        public UnitController(UnitService _UnitService)
        {
            UnitService = _UnitService;
        

        }
        [HttpGet]
        public ResultViewModel<IEnumerable<UnitViewModel>> GetAll()
        {
            ResultViewModel<IEnumerable<UnitViewModel>> result
                 = new ResultViewModel<IEnumerable<UnitViewModel>>();

            try
            {
               
                    result.Successed = true;
                    result.Data = UnitService.GetAll();;
                
            }
            catch (Exception ex)
            {
                result.Successed = false;
                result.Message = "Semething Went Wrong";
            }
            return result;

           
        }
        [HttpGet]
        public ResultViewModel<UnitViewModel> GetByID(int id)
        {
            ResultViewModel<UnitViewModel> result
                = new ResultViewModel<UnitViewModel>();
            try
            {
                
                result.Successed = true;
                result.Data = UnitService.GetByID(id).ToViewModel();
                if (result.Data == null)
                    result.Message = "Unit Not Found !";

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
            if (UnitService.GetByID(id) != null)
            {
                UnitService.Remove(id);
                return "Unit Deleted Sucessfully";
            }
            else
                return "Unit Not Found !";
        }

        [HttpPost]
        public ResultViewModel<UnitEditViewModel> Update(UnitEditViewModel emp)
        {
            ResultViewModel<UnitEditViewModel> result
                = new ResultViewModel<UnitEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Model State";
                }
                else
                {
                    UnitEditViewModel selectedEmp
                        = UnitService.Update(emp);

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
        public ResultViewModel<UnitEditViewModel> Add(UnitEditViewModel emp)
        {
            ResultViewModel<UnitEditViewModel> result
                = new ResultViewModel<UnitEditViewModel>();

            try
            {
                if (!ModelState.IsValid)
                {
                    result.Message = "In Valid Unit Name";
                }
                else
                {
                    UnitEditViewModel selectedEmp
                        = UnitService.Add(emp);
                    
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










    
