using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyInformationDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyInformationMapping : IDisposable, ICompanyInformationMapping
    {
        public List<CompanyInformationReturnDTO> MappingCompanyInformationToCompanyInformationReturnDTO(List<CompanyInformation> CompanyInformationList)
        {

            List<CompanyInformationReturnDTO> CompanyInformationReturnDTOList = null;
            try
            {
                if (CompanyInformationList.Any() && CompanyInformationList != null)
                {
                    CompanyInformationReturnDTOList = CompanyInformationList.Select(u => new CompanyInformationReturnDTO
                    {
                        CompanyInformationId = u.CompanyInformationId,
                        CompanyName = u.CompanyName,
                        CompanyPhone = u.CompanyPhone,
                        CompanyProfile = u.CompanyProfile,
                        CompanySizeId = u.CompanySizeId,
                        CompanyTypeId = (byte)u.CompanyTypeId,
                        CompanyWebsite = u.CompanyWebsite,
                        EmployerId = u.EmployerId,
                        Fax = u.Fax,
                        IsMultinational = (bool)u.IsMultinational,
                        IsStartupCompany = (bool)u.IsStartupCompany,
                        Specialties = u.Specialties,
                        YearFounded = (int)u.YearFounded,
                        Logo = u.Logo

                    }).ToList();
                }
            }
            catch (Exception exception)
            {

            }
            return CompanyInformationReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyInformation></returns>
        public CompanyInformation MappingCompanyInformationAddDTOToCompanyInformation(CompanyInformationAddDTO CompanyInformationAddDTO)
        {
            #region Declare a return type with initial value.
            CompanyInformation CompanyInformation = null;
            #endregion
            try
            {
                CompanyInformation = new CompanyInformation
                {
                    CompanyName = CompanyInformationAddDTO.CompanyName,
                    CompanyPhone = CompanyInformationAddDTO.CompanyPhone,
                    CompanyProfile = CompanyInformationAddDTO.CompanyProfile,
                    CompanySizeId = CompanyInformationAddDTO.CompanySizeId,
                    CompanyTypeId = (byte)CompanyInformationAddDTO.CompanyTypeId,
                    CompanyWebsite = CompanyInformationAddDTO.CompanyWebsite,
                    EmployerId = CompanyInformationAddDTO.EmployerId,
                    Fax = CompanyInformationAddDTO.Fax,
                    IsMultinational = (bool)CompanyInformationAddDTO.IsMultinational,
                    IsStartupCompany = (bool)CompanyInformationAddDTO.IsStartupCompany,
                    Specialties = CompanyInformationAddDTO.Specialties,
                    YearFounded = (int)CompanyInformationAddDTO.YearFounded,
                    Logo = CompanyInformationAddDTO.Logo,
                    CreationDate = DateTime.Now,
                    IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                };
            }
            catch (Exception exception) { }
            return CompanyInformation;
        }
        /// <summary>
        /// Mapping User Activity Log DTO to Action
        /// </summary>
        /// <param name=></param>
        /// <param name=></param>
        /// <returns></returns>
        public CompanyInformation MappingCompanyInformationupdateDTOToCompanyInformation(CompanyInformation companyInformation, CompanyInformationUpdateDTO CompanyInformationUpdateDTO)
        {
            #region Declare Return Var with Intial Value
            CompanyInformation CompanyInformation = companyInformation;
            #endregion
            try
            {
                if (CompanyInformationUpdateDTO.CompanyInformationId > default(int))
                {
                    CompanyInformation.CompanyInformationId = CompanyInformationUpdateDTO.CompanyInformationId;
                   CompanyInformation.CompanyName = CompanyInformationUpdateDTO.CompanyName;
                   CompanyInformation.CompanyPhone = CompanyInformationUpdateDTO.CompanyPhone;
                   CompanyInformation.CompanyProfile = CompanyInformationUpdateDTO.CompanyProfile;
                   CompanyInformation.CompanySizeId = CompanyInformationUpdateDTO.CompanySizeId;
                   CompanyInformation.CompanyTypeId = (byte)CompanyInformationUpdateDTO.CompanyTypeId;
                   CompanyInformation.CompanyWebsite = CompanyInformationUpdateDTO.CompanyWebsite;
                   CompanyInformation.EmployerId = CompanyInformationUpdateDTO.EmployerId;
                   CompanyInformation.Fax = CompanyInformationUpdateDTO.Fax;
                   CompanyInformation.IsMultinational = (bool)CompanyInformationUpdateDTO.IsMultinational;
                   CompanyInformation.IsStartupCompany = (bool)CompanyInformationUpdateDTO.IsStartupCompany;
                   CompanyInformation.Specialties = CompanyInformationUpdateDTO.Specialties;
                   CompanyInformation.YearFounded = (int)CompanyInformationUpdateDTO.YearFounded;
                   CompanyInformation.Logo = CompanyInformationUpdateDTO.Logo;
                }
            }
            catch (Exception exception) { }
            return CompanyInformation;
        }
        public CompanyInformationReturnDTO MappingCompanyInformationToCompanyInformationReturnDTO(CompanyInformation CompanyInformation)
        {
            #region Declare a return type with initial value.
            CompanyInformationReturnDTO CompanyInformationReturnDTO = null;
            #endregion
            try
            {
                if (CompanyInformation != null)
                {
                    CompanyInformationReturnDTO = new CompanyInformationReturnDTO
                    {

                        CompanyInformationId = CompanyInformation.CompanyInformationId,
                        CompanyName = CompanyInformation.CompanyName,
                        CompanyPhone = CompanyInformation.CompanyPhone,
                        CompanyProfile = CompanyInformation.CompanyProfile,
                        CompanySizeId = CompanyInformation.CompanySizeId,
                        CompanyTypeId = (byte)CompanyInformation.CompanyTypeId,
                        CompanyWebsite = CompanyInformation.CompanyWebsite,
                        EmployerId = CompanyInformation.EmployerId,
                        Fax = CompanyInformation.Fax,
                        IsMultinational = (bool)CompanyInformation.IsMultinational,
                        IsStartupCompany = (bool)CompanyInformation.IsStartupCompany,
                        Specialties = CompanyInformation.Specialties,
                        YearFounded = (int)CompanyInformation.YearFounded,
                        Logo = CompanyInformation.Logo,
                    
                    };
                }
            }
            catch (Exception exception)
            { }
            return CompanyInformationReturnDTO;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}




