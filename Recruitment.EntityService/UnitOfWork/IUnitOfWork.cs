using System;
using System.Threading.Tasks;
using Recruitment.Data.EntitiesService.Repository;

namespace Recruitment.EntitiesService.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IIndustryRepository IndustryRepository { get; }
        IGradeRepository GradeRepository { get; }
        ICareerLevelRepository CareerLevelRepository { get; }
        ICityRepository CityRepository { get; }
        ICurrentCareerLevelRepository CurrentCareerLevelRepository { get; }
        IJobRoleRepository JobRoleRepository { get; }
        ICurrentJobSearchStatusRepository CurrentJobSearchStatusRepository { get; }
        IEmployerRepository EmployerRepository { get; }
        ICountryRepository CountryRepository { get; }
        ICurrentEducationalLevelRepository CurrentEducationalLevelRepository { get; }
        ICompanyCoverImageRepository CompanyCoverImageRepository { get; }
        ICompanyImageRepository CompanyImageRepository { get; }
        ICompanyIndustryRepository CompanyIndustryRepository { get; }
        ICompanyInformationRepository CompanyInformationRepository { get; }
        ICompanyOnlinePresenceRepository CompanyOnlinePresenceRepository { get; }
        ICompanySizeRepository CompanySizeRepository { get; }
        ICompanyTypeRepository CompanyTypeRepository { get; }
        ICompanyUserRepository CompanyUserRepository { get; }
        ICompanyUserTypeRepository CompanyUserTypeRepository { get; }
        IEmployerJobRoleRepository EmployerJobRoleRepository { get; }
        IJobSeekerRepository JobSeekerRepository { get; }
        IJobSeekerApplyRepository JobSeekerApplyRepository { get; }
        IJobSeekerApplyStatusRepository JobSeekerApplyStatusRepository { get; }
        IJobSeekerExperienceRepository JobSeekerExperienceRepository { get; }
        IJobSeekerFieldOfStudyRepository JobSeekerFieldOfStudyRepository { get; }
        IJobSeekerGradeRepository JobSeekerGradeRepository { get; }
        IJobSeekerProfessionalInformationRepository JobSeekerProfessionalInformationRepository { get; }
        IJobSeekerRoleRepository JobSeekerRoleRepository { get; }
        IJobSeekerSkillsRepository JobSeekerSkillsRepository { get; }
     
        Task<int> Commit();
    }
}
