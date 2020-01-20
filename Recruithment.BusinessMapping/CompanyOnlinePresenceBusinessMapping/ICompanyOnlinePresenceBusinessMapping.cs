using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICompanyOnlinePresenceBusinessMapping
    {
        Task<List<CompanyOnlinePresenceReturnDTO>> GetAllCompanyOnlinePresences();
        Task<bool> AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO CompanyOnlinePresenceAddDTO);
        Task<CompanyOnlinePresenceReturnDTO> GetCompanyOnlinePresenceById(int CompanyOnlinePresenceId);
        Task<bool> UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO CompanyOnlinePresenceUpdateDTO);
        Task<bool> DeleteCompanyOnlinePresence(int CompanyOnlinePresenceId);
    }
}

