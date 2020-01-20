using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyUserTypeRepository : BaseRepository<CompanyUserType>, ICompanyUserTypeRepository
    {
        public CompanyUserTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

