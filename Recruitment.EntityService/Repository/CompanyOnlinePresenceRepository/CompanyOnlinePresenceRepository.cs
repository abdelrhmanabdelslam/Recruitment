using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyOnlinePresenceRepository : BaseRepository<CompanyOnlinePresence>, ICompanyOnlinePresenceRepository
    {
        public CompanyOnlinePresenceRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

