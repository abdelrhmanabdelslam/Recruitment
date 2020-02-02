using Recruitment.Entity;
using Recruitment.Data.EntitiesService.CreateRepository;
using Recruitment.Data.EntitiesService.DeleteRepository;
using Recruitment.Data.EntitiesService.ReadRepository;
using Recruitment.Data.EntitiesService.UpdateRepository;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
   public  interface IJobSeekerApplyStatusRepository : ICreateRepository<JobSeekerApplyStatus>, IReadRepository<JobSeekerApplyStatus>, IUpdateRepository<JobSeekerApplyStatus>, IDeleteRepository<JobSeekerApplyStatus>
    {

    }
}

