using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyInformationRepository : BaseRepository<CompanyInformation>, ICompanyInformationRepository
    {
        public CompanyInformationRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

