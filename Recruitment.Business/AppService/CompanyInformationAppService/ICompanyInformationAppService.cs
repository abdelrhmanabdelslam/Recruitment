
using Recruitment.DTOS.CompanyInformationDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyInformationAppService
    {
        Task<List<CompanyInformationReturnDTO>> GetAllCompanyInformations();
        Task<bool> AddCompanyInformation(CompanyInformationAddDTO userAddDTO);
        Task<CompanyInformationReturnDTO> GetCompanyInformationById(int CompanyInformationId);
        Task<bool> UpdateCompanyInformation(CompanyInformationUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyInformation(int CompanyInformationId);
    }
}




