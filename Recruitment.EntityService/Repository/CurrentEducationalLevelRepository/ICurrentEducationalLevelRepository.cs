using Recruitment.Entity;
using Recruitment.Data.EntitiesService.CreateRepository;
using Recruitment.Data.EntitiesService.DeleteRepository;
using Recruitment.Data.EntitiesService.ReadRepository;
using Recruitment.Data.EntitiesService.UpdateRepository;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
   public  interface ICurrentEducationalLevelRepository : ICreateRepository<CurrentEducationalLevel>, IReadRepository<CurrentEducationalLevel>, IUpdateRepository<CurrentEducationalLevel>, IDeleteRepository<CurrentEducationalLevel>
    {

    }
}

