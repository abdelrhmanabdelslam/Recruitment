
using Recruitment.DTOS.ReferralDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface IReferralAppService
    {
        Task<List<ReferralReturnDTO>> GetAllReferrals();
        Task<bool> AddReferral(ReferralAddDTO userAddDTO);
        Task<ReferralReturnDTO> GetReferralById(int ReferralId);
        Task<bool> UpdateReferral(ReferralUpdateDTO userUpdateDTO);
        Task<bool> DeleteReferral(int ReferralId);
    }
}




