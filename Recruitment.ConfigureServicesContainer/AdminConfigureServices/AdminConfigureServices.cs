using Microsoft.Extensions.DependencyInjection;
using Recruitment.Business.AppService;
using Recruitment.Data.EntitiesService.Repository;
using Recruitment.DataService.BusinessMapping;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.ConfigureServicesContainer.AdminConfigureServices
{
    public static class AdminConfigureServices
    {
        public static void ConfigureAdminServicesDI(this IServiceCollection services)
        {

            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IIndustryRepository, IndustryRepository>();
            services.AddSingleton<IIndustryBusinessMapping, IndustryBusinessMapping>();
            services.AddSingleton<IIndustryMapping, IndustryMapping>();
            services.AddSingleton<IIndustryAppService, IndustryAppService>();

            services.AddSingleton<IGradeRepository, GradeRepository>();
            services.AddSingleton<IGradeBusinessMapping, GradeBusinessMapping>();
            services.AddSingleton<IGradeMapping, GradeMapping>();
            services.AddSingleton<IGradeAppService, GradeAppService>();

            services.AddSingleton<ICareerLevelRepository, CareerLevelRepository>();
            services.AddSingleton<ICareerLevelBusinessMapping, CareerLevelBusinessMapping>();
            services.AddSingleton<ICareerLevelMapping, CareerLevelMapping>();
            services.AddSingleton<ICareerLevelAppService, CareerLevelAppService>();


            services.AddSingleton<ICityRepository, CityRepository>();
            services.AddSingleton<ICityBusinessMapping, CityBusinessMapping>();
            services.AddSingleton<ICityMapping, CityMapping>();
            services.AddSingleton<ICityAppService, CityAppService>();


            services.AddSingleton<ICurrentCareerLevelRepository, CurrentCareerLevelRepository>();
            services.AddSingleton<ICurrentCareerLevelBusinessMapping, CurrentCareerLevelBusinessMapping>();
            services.AddSingleton<ICurrentCareerLevelMapping, CurrentCareerLevelMapping>();
            services.AddSingleton<ICurrentCareerLevelAppService, CurrentCareerLevelAppService>();

            services.AddSingleton<ICountryRepository, CountryRepository>();
            services.AddSingleton<ICountryBusinessMapping, CountryBusinessMapping>();
            services.AddSingleton<ICountryMapping, CountryMapping>();
            services.AddSingleton<ICountryAppService, CountryAppService>();

            services.AddSingleton<IJobRoleRepository, JobRoleRepository>();
            services.AddSingleton<IJobRoleBusinessMapping, JobRoleBusinessMapping>();
            services.AddSingleton<IJobRoleMapping, JobRoleMapping>();
            services.AddSingleton<IJobRoleAppService, JobRoleAppService>();

            services.AddSingleton<ICurrentJobSearchStatusRepository, CurrentJobSearchStatusRepository>();
            services.AddSingleton<ICurrentJobSearchStatusBusinessMapping, CurrentJobSearchStatusBusinessMapping>();
            services.AddSingleton<ICurrentJobSearchStatusMapping, CurrentJobSearchStatusMapping>();
            services.AddSingleton<ICurrentJobSearchStatusAppService, CurrentJobSearchStatusAppService>();


            services.AddSingleton<IEmployerRepository, EmployerRepository>();
            services.AddSingleton<IEmployerBusinessMapping, EmployerBusinessMapping>();
            services.AddSingleton<IEmployerMapping, EmployerMapping>();
            services.AddSingleton<IEmployerAppService, EmployerAppService>();

            services.AddSingleton<ICurrentEducationalLevelRepository, CurrentEducationalLevelRepository>();
            services.AddSingleton<ICurrentEducationalLevelBusinessMapping, CurrentEducationalLevelBusinessMapping>();
            services.AddSingleton<ICurrentEducationalLevelMapping, CurrentEducationalLevelMapping>();
            services.AddSingleton<ICurrentEducationalLevelAppService, CurrentEducationalLevelAppService>();

       services.AddSingleton<ICompanyCoverImageRepository, CompanyCoverImageRepository>();
            services.AddSingleton<ICompanyCoverImageBusinessMapping, CompanyCoverImageBusinessMapping>();
            services.AddSingleton<ICompanyCoverImageMapping, CompanyCoverImageMapping>();
            services.AddSingleton<ICompanyCoverImageAppService, CompanyCoverImageAppService>();

  services.AddSingleton<ICompanyImageRepository, CompanyImageRepository>();
            services.AddSingleton<ICompanyImageBusinessMapping, CompanyImageBusinessMapping>();
            services.AddSingleton<ICompanyImageMapping, CompanyImageMapping>();
            services.AddSingleton<ICompanyImageAppService, CompanyImageAppService>();

            services.AddSingleton<ICompanyIndustryRepository, CompanyIndustryRepository>();
            services.AddSingleton<ICompanyIndustryBusinessMapping, CompanyIndustryBusinessMapping>();
            services.AddSingleton<ICompanyIndustryMapping, CompanyIndustryMapping>();
            services.AddSingleton<ICompanyIndustryAppService, CompanyIndustryAppService>();


            services.AddSingleton<ICompanyInformationRepository, CompanyInformationRepository>();
            services.AddSingleton<ICompanyInformationBusinessMapping, CompanyInformationBusinessMapping>();
            services.AddSingleton<ICompanyInformationMapping, CompanyInformationMapping>();
            services.AddSingleton<ICompanyInformationAppService, CompanyInformationAppService>();

            services.AddSingleton<ICompanyOnlinePresenceRepository, CompanyOnlinePresenceRepository>();
            services.AddSingleton<ICompanyOnlinePresenceBusinessMapping, CompanyOnlinePresenceBusinessMapping>();
            services.AddSingleton<ICompanyOnlinePresenceMapping, CompanyOnlinePresenceMapping>();
            services.AddSingleton<ICompanyOnlinePresenceAppService, CompanyOnlinePresenceAppService>();


            services.AddSingleton<ICompanySizeRepository, CompanySizeRepository>();
            services.AddSingleton<ICompanySizeBusinessMapping, CompanySizeBusinessMapping>();
            services.AddSingleton<ICompanySizeMapping, CompanySizeMapping>();
            services.AddSingleton<ICompanySizeAppService, CompanySizeAppService>();


            services.AddSingleton<ICompanyTypeRepository, CompanyTypeRepository>();
            services.AddSingleton<ICompanyTypeBusinessMapping, CompanyTypeBusinessMapping>();
            services.AddSingleton<ICompanyTypeMapping, CompanyTypeMapping>();
            services.AddSingleton<ICompanyTypeAppService, CompanyTypeAppService>();



            services.AddSingleton<ICompanyUserRepository, CompanyUserRepository>();
            services.AddSingleton<ICompanyUserBusinessMapping, CompanyUserBusinessMapping>();
            services.AddSingleton<ICompanyUserMapping, CompanyUserMapping>();
            services.AddSingleton<ICompanyUserAppService, CompanyUserAppService>();

            services.AddSingleton<ICompanyUserTypeRepository,CompanyUserTypeRepository>();
            services.AddSingleton<ICompanyUserTypeBusinessMapping, CompanyUserTypeBusinessMapping>();
            services.AddSingleton<ICompanyUserTypeMapping, CompanyUserTypeMapping>();
            services.AddSingleton<ICompanyUserTypeAppService, CompanyUserTypeAppService>();

            services.AddSingleton<IEmployerJobRoleBusinessMapping, EmployerJobRoleBusinessMapping>();
            services.AddSingleton<IEmployerJobRoleMapping, EmployerJobRoleMapping>();
            services.AddSingleton<IEmployerJobRoleAppService, EmployerJobRoleAppService>();

            services.AddSingleton<IJobSeekerBusinessMapping, JobSeekerBusinessMapping>();
            services.AddSingleton<IJobSeekerMapping, JobSeekerMapping>();
            services.AddSingleton<IJobSeekerAppService, JobSeekerAppService>();

            services.AddSingleton<IJobSeekerApplyStatusBusinessMapping, JobSeekerApplyStatusBusinessMapping>();
            services.AddSingleton<IJobSeekerApplyStatusMapping, JobSeekerApplyStatusMapping>();
            services.AddSingleton<IJobSeekerApplyStatusAppService, JobSeekerApplyStatusAppService>();


            services.AddSingleton<IJobSeekerApplyBusinessMapping, JobSeekerApplyBusinessMapping>();
            services.AddSingleton<IJobSeekerApplyMapping, JobSeekerApplyMapping>();
            services.AddSingleton<IJobSeekerApplyAppService, JobSeekerApplyAppService>();

            services.AddSingleton<IJobSeekerExperienceBusinessMapping, JobSeekerExperienceBusinessMapping>();
            services.AddSingleton<IJobSeekerExperienceMapping, JobSeekerExperienceMapping>();
            services.AddSingleton<IJobSeekerExperienceAppService, JobSeekerExperienceAppService>();

            services.AddSingleton<IJobSeekerFieldOfStudyBusinessMapping, JobSeekerFieldOfStudyBusinessMapping>();
            services.AddSingleton<IJobSeekerFieldOfStudyMapping, JobSeekerFieldOfStudyMapping>();
            services.AddSingleton<IJobSeekerFieldOfStudyAppService, JobSeekerFieldOfStudyAppService>();

            services.AddSingleton<IJobSeekerGradeBusinessMapping, JobSeekerGradeBusinessMapping>();
            services.AddSingleton<IJobSeekerGradeMapping, JobSeekerGradeMapping>();
            services.AddSingleton<IJobSeekerGradeAppService, JobSeekerGradeAppService>();

            services.AddSingleton<IJobSeekerProfessionalInformationBusinessMapping, JobSeekerProfessionalInformationBusinessMapping>();
            services.AddSingleton<IJobSeekerProfessionalInformationMapping, JobSeekerProfessionalInformationMapping>();
            services.AddSingleton<IJobSeekerProfessionalInformationAppService, JobSeekerProfessionalInformationAppService>();


            services.AddSingleton<IJobSeekerRoleBusinessMapping, JobSeekerRoleBusinessMapping>();
            services.AddSingleton<IJobSeekerRoleMapping, JobSeekerRoleMapping>();
            services.AddSingleton<IJobSeekerRoleAppService, JobSeekerRoleAppService>();


            services.AddSingleton<IJobSeekerSkillsBusinessMapping, JobSeekerSkillsBusinessMapping>();
            services.AddSingleton<IJobSeekerSkillsMapping, JobSeekerSkillsMapping>();
            services.AddSingleton<IJobSeekerSkillsAppService, JobSeekerSkillsAppService>();
        }
    }
}