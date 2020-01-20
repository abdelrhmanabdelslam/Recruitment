using Recruitment.DTOS.CurrentJobSearchStatusDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ICurrentJobSearchStatusBusinessMapping
    {
        Task<List<CurrentJobSearchStatusReturnDTO>> GetAllCurrentJobSearchStatuss();
        Task<bool> AddCurrentJobSearchStatus(CurrentJobSearchStatusAddDTO CurrentJobSearchStatusAddDTO);
        Task<CurrentJobSearchStatusReturnDTO> GetCurrentJobSearchStatusById(int CurrentJobSearchStatusId);
        Task<bool> UpdateCurrentJobSearchStatus(CurrentJobSearchStatusUpdateDTO CurrentJobSearchStatusUpdateDTO);
        Task<bool> DeleteCurrentJobSearchStatus(int CurrentJobSearchStatusId);
    }
}

