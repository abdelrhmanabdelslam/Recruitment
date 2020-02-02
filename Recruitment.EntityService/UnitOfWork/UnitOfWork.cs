using Recruitment.Data.EntitiesService.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Recruitment.Common.Helper;
using Recruitment.Entity.Models;

namespace Recruitment.EntitiesService.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties
        private DbContext RecruitmentDbContext { get; set; }
        #endregion
        #region Repositories
        public IIndustryRepository IndustryRepository { get => new IndustryRepository(RecruitmentDbContext); }
        public IGradeRepository GradeRepository { get => new GradeRepository(RecruitmentDbContext); }
        public ICareerLevelRepository CareerLevelRepository { get => new CareerLevelRepository(RecruitmentDbContext); }
        public ICityRepository CityRepository { get => new CityRepository(RecruitmentDbContext); }
        public ICurrentCareerLevelRepository CurrentCareerLevelRepository { get => new CurrentCareerLevelRepository(RecruitmentDbContext); }
        public ICountryRepository CountryRepository { get => new CountryRepository(RecruitmentDbContext); }
        public IJobRoleRepository JobRoleRepository { get => new JobRoleRepository(RecruitmentDbContext); }
        public ICurrentJobSearchStatusRepository CurrentJobSearchStatusRepository { get => new CurrentJobSearchStatusRepository(RecruitmentDbContext); }
        public IEmployerRepository EmployerRepository { get => new EmployerRepository(RecruitmentDbContext); }
        public ICurrentEducationalLevelRepository CurrentEducationalLevelRepository { get => new CurrentEducationalLevelRepository(RecruitmentDbContext); }
        public ICompanyCoverImageRepository CompanyCoverImageRepository { get => new CompanyCoverImageRepository(RecruitmentDbContext); }
        public ICompanyImageRepository CompanyImageRepository { get => new CompanyImageRepository(RecruitmentDbContext); }
        public ICompanyIndustryRepository CompanyIndustryRepository { get => new CompanyIndustryRepository(RecruitmentDbContext); }
        public ICompanyInformationRepository CompanyInformationRepository { get => new CompanyInformationRepository(RecruitmentDbContext); }
        public ICompanyOnlinePresenceRepository CompanyOnlinePresenceRepository { get => new CompanyOnlinePresenceRepository(RecruitmentDbContext); }
        public ICompanySizeRepository CompanySizeRepository { get => new CompanySizeRepository(RecruitmentDbContext); }
        public ICompanyTypeRepository CompanyTypeRepository { get => new CompanyTypeRepository(RecruitmentDbContext); }
        public ICompanyUserRepository CompanyUserRepository { get => new CompanyUserRepository(RecruitmentDbContext); }
        public ICompanyUserTypeRepository CompanyUserTypeRepository { get => new CompanyUserTypeRepository(RecruitmentDbContext); }
        public IEmployerJobRoleRepository EmployerJobRoleRepository { get => new EmployerJobRoleRepository(RecruitmentDbContext); }
        public IJobSeekerRepository JobSeekerRepository { get => new JobSeekerRepository(RecruitmentDbContext); }
        public IJobSeekerApplyRepository JobSeekerApplyRepository { get => new JobSeekerApplyRepository(RecruitmentDbContext); }
        public IJobSeekerApplyStatusRepository JobSeekerApplyStatusRepository { get => new JobSeekerApplyStatusRepository(RecruitmentDbContext); }
        public IJobSeekerExperienceRepository JobSeekerExperienceRepository { get => new JobSeekerExperienceRepository(RecruitmentDbContext); }
        public IJobSeekerFieldOfStudyRepository JobSeekerFieldOfStudyRepository { get => new JobSeekerFieldOfStudyRepository(RecruitmentDbContext); }
        public IJobSeekerGradeRepository JobSeekerGradeRepository { get => new JobSeekerGradeRepository(RecruitmentDbContext); }
        public IJobSeekerProfessionalInformationRepository JobSeekerProfessionalInformationRepository { get => new JobSeekerProfessionalInformationRepository(RecruitmentDbContext); }
        public IJobSeekerRoleRepository JobSeekerRoleRepository { get => new JobSeekerRoleRepository(RecruitmentDbContext); }
        public IJobSeekerSkillsRepository JobSeekerSkillsRepository { get => new JobSeekerSkillsRepository(RecruitmentDbContext); }
        public IJobSeekerTypeOfJobRepository JobSeekerTypeOfJobRepository { get => new JobSeekerTypeOfJobRepository(RecruitmentDbContext); }
        public IJobSekeerLanguagesRepository JobSekeerLanguagesRepository { get => new JobSekeerLanguagesRepository(RecruitmentDbContext); }
        public ILanguageRepository LanguageRepository { get => new LanguageRepository(RecruitmentDbContext); }
        public ILanguageLevelRepository LanguageLevelRepository { get => new LanguageLevelRepository(RecruitmentDbContext); }
        public IPostRepository PostRepository { get => new PostRepository(RecruitmentDbContext); }
        public IPostIndustryRepository PostIndustryRepository { get => new PostIndustryRepository(RecruitmentDbContext); }
        public IPostJobRoleRepository PostJobRoleRepository { get => new PostJobRoleRepository(RecruitmentDbContext); }
        public IPostRelatedIndustryRepository PostRelatedIndustryRepository { get => new PostRelatedIndustryRepository(RecruitmentDbContext); }
        public IPostTypeRepository PostTypeRepository { get => new PostTypeRepository(RecruitmentDbContext); }
        public IReferralRepository ReferralRepository { get => new ReferralRepository(RecruitmentDbContext); }
        public ITypeOfJobRepository TypeOfJobRepository { get => new TypeOfJobRepository(RecruitmentDbContext); }
        #endregion
        #region Constractor
        public UnitOfWork()
        {
            RecruitmentDbContext = new RecruitmentContext(ConfigHelper.ConnectionString, ConfigHelper.ConnectionTimeout);
        }
        #endregion
        #region Methods
        /// <summary>
        /// Commit changes of DbContext
        /// </summary>
        /// <returns>Number of effected entities</returns>
        public async Task<int> Commit()
        {
            #region Declare a return type with initial value.
            int isCommited = default(int);
            #endregion
            try
            {
                if (RecruitmentDbContext.ChangeTracker.HasChanges())
                {
                    isCommited += await RecruitmentDbContext.SaveChangesAsync();
                }
            }
            catch (Exception exception)
            {

            }
            return isCommited;
        }
        /// <summary>
        /// Dispose the UnitOfWork and DbContext objects
        /// </summary>
        public void Dispose()
        {
            try
            {
                RecruitmentDbContext.Dispose();
            }
            catch (Exception exception)
            {

            }
        }
        #endregion
    }
}
