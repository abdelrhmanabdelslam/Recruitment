using Recruitment.DTOS.TypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
   public  interface ITypeOfJobBusinessMapping
    {
        Task<List<TypeOfJobReturnDTO>> GetAllTypeOfJobs();
        Task<bool> AddTypeOfJob(TypeOfJobAddDTO TypeOfJobAddDTO);
        Task<TypeOfJobReturnDTO> GetTypeOfJobById(int TypeOfJobId);
        Task<bool> UpdateTypeOfJob(TypeOfJobUpdateDTO TypeOfJobUpdateDTO);
        Task<bool> DeleteTypeOfJob(int TypeOfJobId);
    }
}

