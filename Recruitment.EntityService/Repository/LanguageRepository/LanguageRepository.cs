using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

