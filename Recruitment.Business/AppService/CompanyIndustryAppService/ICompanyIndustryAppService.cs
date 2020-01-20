
using Recruitment.DTOS.CompanyIndustryDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyIndustryAppService
    {
        Task<List<CompanyIndustryReturnDTO>> GetAllCompanyIndustrys();
        Task<bool> AddCompanyIndustry(CompanyIndustryAddDTO userAddDTO);
        Task<CompanyIndustryReturnDTO> GetCompanyIndustryById(int CompanyIndustryId);
        Task<bool> UpdateCompanyIndustry(CompanyIndustryUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyIndustry(int CompanyIndustryId);
    }
}




