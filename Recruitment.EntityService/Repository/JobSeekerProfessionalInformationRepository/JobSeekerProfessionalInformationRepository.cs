using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerProfessionalInformationRepository : BaseRepository<JobSeekerProfessionalInformation>, IJobSeekerProfessionalInformationRepository
    {
        public JobSeekerProfessionalInformationRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

