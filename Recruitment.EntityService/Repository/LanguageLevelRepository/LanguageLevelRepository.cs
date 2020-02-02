using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class LanguageLevelRepository : BaseRepository<LanguageLevel>, ILanguageLevelRepository
    {
        public LanguageLevelRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

