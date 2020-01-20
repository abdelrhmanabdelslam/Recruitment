using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface ICurrentJobSearchStatusMapping
    {
        List<CurrentJobSearchStatusReturnDTO> MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(List<CurrentJobSearchStatus> CurrentJobSearchStatusList);
        CurrentJobSearchStatus MappingCurrentJobSearchStatusAddDTOToCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO CurrentJobSearchStatusAddDTO);
        CurrentJobSearchStatus MappingCurrentJobSearchStatusupdateDTOToCurrentJobSearchStatus(CurrentJobSearchStatus CurrentJobSearchStatus,CurrentJobSearchStatusUpdateDTO CurrentJobSearchStatusUpdateDTO);
        CurrentJobSearchStatusReturnDTO MappingCurrentJobSearchStatusToCurrentJobSearchStatusReturnDTO(CurrentJobSearchStatus CurrentJobSearchStatus);

    }
}




