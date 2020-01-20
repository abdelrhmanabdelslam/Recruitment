
using Recruitment.DTOS.CompanyUserTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyUserTypeAppService
    {
        Task<List<CompanyUserTypeReturnDTO>> GetAllCompanyUserTypes();
        Task<bool> AddCompanyUserType(CompanyUserTypeAddDTO userAddDTO);
        Task<CompanyUserTypeReturnDTO> GetCompanyUserTypeById(int CompanyUserTypeId);
        Task<bool> UpdateCompanyUserType(CompanyUserTypeUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyUserType(int CompanyUserTypeId);
    }
}




