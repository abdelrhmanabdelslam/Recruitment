using Recruitment.DTOS.CompanyInformationDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyInformationBusinessMapping
    {
        Task<List<CompanyInformationReturnDTO>> GetAllCompanyInformations();
        Task<bool> AddCompanyInformation(CompanyInformationAddDTO CompanyInformationAddDTO);
        Task<CompanyInformationReturnDTO> GetCompanyInformationById(int CompanyInformationId);
        Task<bool> UpdateCompanyInformation(CompanyInformationUpdateDTO CompanyInformationUpdateDTO);
        Task<bool> DeleteCompanyInformation(int CompanyInformationId);
    }
}

