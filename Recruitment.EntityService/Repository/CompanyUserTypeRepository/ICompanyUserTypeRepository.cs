using Recruitment.Entity;
using Recruitment.Data.EntitiesService.CreateRepository;
using Recruitment.Data.EntitiesService.DeleteRepository;
using Recruitment.Data.EntitiesService.ReadRepository;
using Recruitment.Data.EntitiesService.UpdateRepository;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
   public  interface ICompanyUserTypeRepository : ICreateRepository<CompanyUserType>, IReadRepository<CompanyUserType>, IUpdateRepository<CompanyUserType>, IDeleteRepository<CompanyUserType>
    {

    }
}

