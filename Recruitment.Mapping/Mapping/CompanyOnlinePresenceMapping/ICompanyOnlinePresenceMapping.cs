using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICompanyOnlinePresenceMapping
    {
        List<CompanyOnlinePresenceReturnDTO> MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(List<CompanyOnlinePresence> CompanyOnlinePresenceList);
        CompanyOnlinePresence MappingCompanyOnlinePresenceAddDTOToCompanyOnlinePresence(CompanyOnlinePresenceAddDTO CompanyOnlinePresenceAddDTO);
        CompanyOnlinePresence MappingCompanyOnlinePresenceupdateDTOToCompanyOnlinePresence(CompanyOnlinePresence CompanyOnlinePresence,CompanyOnlinePresenceUpdateDTO CompanyOnlinePresenceUpdateDTO);
        CompanyOnlinePresenceReturnDTO MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(CompanyOnlinePresence CompanyOnlinePresence);

    }
}




