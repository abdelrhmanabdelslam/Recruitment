using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerFieldOfStudyRepository : BaseRepository<JobSeekerFieldOfStudy>, IJobSeekerFieldOfStudyRepository
    {
        public JobSeekerFieldOfStudyRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

