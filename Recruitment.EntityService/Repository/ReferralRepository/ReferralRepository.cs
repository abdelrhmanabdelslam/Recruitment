using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class ReferralRepository : BaseRepository<Referral>, IReferralRepository
    {
        public ReferralRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

