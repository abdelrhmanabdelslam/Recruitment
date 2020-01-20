
using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ICurrentJobSearchStatusAppService
    {
        Task<List<CurrentJobSearchStatusReturnDTO>> GetAllCurrentJobSearchStatuss();
        Task<bool> AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO userAddDTO);
        Task<CurrentJobSearchStatusReturnDTO> GetCurrentJobSearchStatusById(int CurrentJobSearchStatusId);
        Task<bool> UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO userUpdateDTO);
        Task<bool> DeleteCurrentJobSearchStatus(int CurrentJobSearchStatusId);
    }
}




