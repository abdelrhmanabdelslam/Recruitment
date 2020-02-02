using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSekeerLanguagesRepository : BaseRepository<JobSekeerLanguages>, IJobSekeerLanguagesRepository
    {
        public JobSekeerLanguagesRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

