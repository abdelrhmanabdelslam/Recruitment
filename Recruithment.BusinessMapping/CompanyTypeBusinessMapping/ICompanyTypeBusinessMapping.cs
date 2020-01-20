using Recruitment.DTOS.CompanyTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyTypeBusinessMapping
    {
        Task<List<CompanyTypeReturnDTO>> GetAllCompanyTypes();
        Task<bool> AddCompanyType(CompanyTypeAddDTO CompanyTypeAddDTO);
        Task<CompanyTypeReturnDTO> GetCompanyTypeById(int CompanyTypeId);
        Task<bool> UpdateCompanyType(CompanyTypeUpdateDTO CompanyTypeUpdateDTO);
        Task<bool> DeleteCompanyType(int CompanyTypeId);
    }
}

