using Recruitment.DTOS.CompanyIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyIndustryBusinessMapping
    {
        Task<List<CompanyIndustryReturnDTO>> GetAllCompanyIndustrys();
        Task<bool> AddCompanyIndustry(CompanyIndustryAddDTO CompanyIndustryAddDTO);
        Task<CompanyIndustryReturnDTO> GetCompanyIndustryById(int CompanyIndustryId);
        Task<bool> UpdateCompanyIndustry(CompanyIndustryUpdateDTO CompanyIndustryUpdateDTO);
        Task<bool> DeleteCompanyIndustry(int CompanyIndustryId);
    }
}

