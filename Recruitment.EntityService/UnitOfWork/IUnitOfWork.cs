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
     
        Task<int> Commit();
    }
}
