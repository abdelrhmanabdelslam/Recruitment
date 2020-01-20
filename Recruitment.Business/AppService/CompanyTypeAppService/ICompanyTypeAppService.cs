
using Recruitment.DTOS.CompanyTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyTypeAppService
    {
        Task<List<CompanyTypeReturnDTO>> GetAllCompanyTypes();
        Task<bool> AddCompanyType(CompanyTypeAddDTO userAddDTO);
        Task<CompanyTypeReturnDTO> GetCompanyTypeById(int CompanyTypeId);
        Task<bool> UpdateCompanyType(CompanyTypeUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyType(int CompanyTypeId);
    }
}




