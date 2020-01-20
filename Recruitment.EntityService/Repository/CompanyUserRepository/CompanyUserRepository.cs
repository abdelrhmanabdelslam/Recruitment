using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyUserRepository : BaseRepository<CompanyUser>, ICompanyUserRepository
    {
        public CompanyUserRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

