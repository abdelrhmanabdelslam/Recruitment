using Recruitment.DTOS.ReferralDTOS;
using Recruitment.Entity.Models;
using System.Collections.Generic;

namespace Recruitment.Mapping.Mapping
{
    public interface IReferralMapping
    {
        List<ReferralReturnDTO> MappingReferralToReferralReturnDTO(List<Referral> ReferralList);
        Referral MappingReferralAddDTOToReferral(ReferralAddDTO ReferralAddDTO);
        Referral MappingReferralupdateDTOToReferral(Referral Referral,ReferralUpdateDTO ReferralUpdateDTO);
        ReferralReturnDTO MappingReferralToReferralReturnDTO(Referral Referral);

    }
}




