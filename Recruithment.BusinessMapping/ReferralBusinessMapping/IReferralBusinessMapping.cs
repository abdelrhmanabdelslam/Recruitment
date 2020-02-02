using Recruitment.DTOS.ReferralDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface IReferralBusinessMapping
    {
        Task<List<ReferralReturnDTO>> GetAllReferrals();
        Task<bool> AddReferral(ReferralAddDTO ReferralAddDTO);
        Task<ReferralReturnDTO> GetReferralById(int ReferralId);
        Task<bool> UpdateReferral(ReferralUpdateDTO ReferralUpdateDTO);
        Task<bool> DeleteReferral(int ReferralId);
    }
}

