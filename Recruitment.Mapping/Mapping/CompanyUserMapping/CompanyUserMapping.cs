using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyUserDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyUserMapping : IDisposable, ICompanyUserMapping
    {
        public List<CompanyUserReturnDTO> MappingCompanyUserToCompanyUserReturnDTO(List<CompanyUser> CompanyUserList)
        {

            List<CompanyUserReturnDTO> CompanyUserReturnDTOList = null;
            try
            {
                if (CompanyUserList.Any() && CompanyUserList != null)
                {
                    CompanyUserReturnDTOList = CompanyUserList.Select(u => new CompanyUserReturnDTO
                    {
                        CompanyInformationId =  u.CompanyInformationId,
                        CompanyUserId = u.CompanyUserId,
                        CompanyUserTypeId = u.CompanyUserTypeId,
                        Email = u.Email,
                        FirstName = u.FirstName,
                        IsAcceptInvitation = u.IsAcceptInvitation,
                        IsActive = u.IsActive,
                        IsCanceled = u.IsCanceled,
                        JobTitile = u.JobTitile,
                        LastName = u.LastName
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyUserReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyUser></returns>
        public CompanyUser MappingCompanyUserAddDTOToCompanyUser(CompanyUserAddDTO CompanyUserAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyUser CompanyUser = null;
                #endregion
                try
                {
                    CompanyUser = new CompanyUser
                    {
                        CompanyInformationId = CompanyUserAddDTO.CompanyInformationId,
                        CompanyUserTypeId = CompanyUserAddDTO.CompanyUserTypeId,
                        Email = CompanyUserAddDTO.Email,
                        FirstName = CompanyUserAddDTO.FirstName,
                        IsAcceptInvitation = CompanyUserAddDTO.IsAcceptInvitation,
                        IsActive = CompanyUserAddDTO.IsActive,
                        IsCanceled = CompanyUserAddDTO.IsCanceled,
                        JobTitile = CompanyUserAddDTO.JobTitile,
                        LastName = CompanyUserAddDTO.LastName,

                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyUser;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyUser MappingCompanyUserupdateDTOToCompanyUser(CompanyUser companyUser, CompanyUserUpdateDTO CompanyUserUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyUser CompanyUser = companyUser;
                #endregion
                try
                {
                    if (CompanyUserUpdateDTO.CompanyUserId > default(int))
                    {
                       CompanyUser.CompanyInformationId = CompanyUserUpdateDTO.CompanyInformationId;
                       CompanyUser.CompanyUserId = CompanyUserUpdateDTO.CompanyUserId;
                       CompanyUser.CompanyUserTypeId = CompanyUserUpdateDTO.CompanyUserTypeId;
                       CompanyUser.Email = CompanyUserUpdateDTO.Email;
                       CompanyUser.FirstName = CompanyUserUpdateDTO.FirstName;
                       CompanyUser.IsAcceptInvitation = CompanyUserUpdateDTO.IsAcceptInvitation;
                       CompanyUser.IsActive = CompanyUserUpdateDTO.IsActive;
                       CompanyUser.IsCanceled = CompanyUserUpdateDTO.IsCanceled;
                       CompanyUser.JobTitile = CompanyUserUpdateDTO.JobTitile;
                        CompanyUser.LastName = CompanyUserUpdateDTO.LastName;

                    }
                }
                catch (Exception exception) { }
                return CompanyUser;
            }
            public CompanyUserReturnDTO MappingCompanyUserToCompanyUserReturnDTO(CompanyUser CompanyUser)
            {
                #region Declare a return type with initial value.
                CompanyUserReturnDTO CompanyUserReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyUser != null)
                    {
                        CompanyUserReturnDTO = new CompanyUserReturnDTO
                        {
                            CompanyInformationId = CompanyUser.CompanyInformationId,
                            CompanyUserId = CompanyUser.CompanyUserId,
                            CompanyUserTypeId = CompanyUser.CompanyUserTypeId,
                            Email = CompanyUser.Email,
                            FirstName = CompanyUser.FirstName,
                            IsAcceptInvitation = CompanyUser.IsAcceptInvitation,
                            IsActive = CompanyUser.IsActive,
                            IsCanceled = CompanyUser.IsCanceled,
                            JobTitile = CompanyUser.JobTitile,
                            LastName = CompanyUser.LastName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyUserReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




