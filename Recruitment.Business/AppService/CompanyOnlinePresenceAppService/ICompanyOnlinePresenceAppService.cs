
using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICompanyOnlinePresenceAppService
    {
        Task<List<CompanyOnlinePresenceReturnDTO>> GetAllCompanyOnlinePresences();
        Task<bool> AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO userAddDTO);
        Task<CompanyOnlinePresenceReturnDTO> GetCompanyOnlinePresenceById(int CompanyOnlinePresenceId);
        Task<bool> UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO userUpdateDTO);
        Task<bool> DeleteCompanyOnlinePresence(int CompanyOnlinePresenceId);
    }
}




