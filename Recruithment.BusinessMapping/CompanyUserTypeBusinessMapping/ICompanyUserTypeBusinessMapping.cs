using Recruitment.DTOS.CompanyUserTypeDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyUserTypeBusinessMapping
    {
        Task<List<CompanyUserTypeReturnDTO>> GetAllCompanyUserTypes();
        Task<bool> AddCompanyUserType(CompanyUserTypeAddDTO CompanyUserTypeAddDTO);
        Task<CompanyUserTypeReturnDTO> GetCompanyUserTypeById(int CompanyUserTypeId);
        Task<bool> UpdateCompanyUserType(CompanyUserTypeUpdateDTO CompanyUserTypeUpdateDTO);
        Task<bool> DeleteCompanyUserType(int CompanyUserTypeId);
    }
}

