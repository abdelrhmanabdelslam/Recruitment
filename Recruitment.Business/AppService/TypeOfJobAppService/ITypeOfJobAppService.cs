
using Recruitment.DTOS.TypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
   public  interface ITypeOfJobAppService
    {
        Task<List<TypeOfJobReturnDTO>> GetAllTypeOfJobs();
        Task<bool> AddTypeOfJob(TypeOfJobAddDTO userAddDTO);
        Task<TypeOfJobReturnDTO> GetTypeOfJobById(int TypeOfJobId);
        Task<bool> UpdateTypeOfJob(TypeOfJobUpdateDTO userUpdateDTO);
        Task<bool> DeleteTypeOfJob(int TypeOfJobId);
    }
}




