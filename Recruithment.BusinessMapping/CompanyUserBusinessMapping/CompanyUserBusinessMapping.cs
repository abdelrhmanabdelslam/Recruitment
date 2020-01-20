using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyUserDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyUserBusinessMapping : BaseBusinessMapping, ICompanyUserBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyUserMapping CompanyUserMapping { get; }
        #endregion

        #region Constructor
        public CompanyUserBusinessMapping(IUnitOfWork unitOfWork, ICompanyUserMapping companyUserMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyUserMapping = companyUserMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyUserReturnDTO></returns>
        public async Task<List<CompanyUserReturnDTO>> GetAllCompanyUsers()
        {
            #region Declare Return Var with Intial Value
            List<CompanyUserReturnDTO> allCompanyUsers = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyUser> CompanyUserList = null;
                #endregion
                CompanyUserList = await UnitOfWork.CompanyUserRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyUserList != null && CompanyUserList.Any())
                {
                    allCompanyUsers = CompanyUserMapping.MappingCompanyUserToCompanyUserReturnDTO(CompanyUserList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyUsers;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyUser(CompanyUserAddDTO CompanyUserAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyUser CompanyUser = null;
                    #endregion
                    CompanyUser = CompanyUserMapping.MappingCompanyUserAddDTOToCompanyUser(CompanyUserAddDTO);
                    if (CompanyUser != null)
                    {
                        await UnitOfWork.CompanyUserRepository.Insert(CompanyUser);
                        isCompanyUserCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyUserReturnDTO></returns>
            public async Task<CompanyUserReturnDTO> GetCompanyUserById(int CompanyUserId)
            {
                #region Declare a return type with initial value.
                CompanyUserReturnDTO CompanyUser = new CompanyUserReturnDTO();
                #endregion
                try
                {
                    CompanyUser companyUser = await UnitOfWork.CompanyUserRepository.GetById(CompanyUserId);
                    if (companyUser != null)
                    {
                        if (companyUser.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyUser = CompanyUserMapping.MappingCompanyUserToCompanyUserReturnDTO(companyUser);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyUser;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyUser(CompanyUserUpdateDTO CompanyUserUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyUserUpdateDTO != null)
                    {
                        #region Vars
                        CompanyUser CompanyUser = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyUser = await UnitOfWork.CompanyUserRepository.GetById(CompanyUserUpdateDTO.CompanyUserId);
                        #endregion
                        if (CompanyUser != null)
                        {
                            #region  Mapping
                            CompanyUser = CompanyUserMapping.MappingCompanyUserupdateDTOToCompanyUser(CompanyUser ,CompanyUserUpdateDTO);
                            #endregion
                            if (CompanyUser != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyUserRepository.Update(CompanyUser);
                                isCompanyUserUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyUser(int CompanyUserId)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyUserId > default(int))
                    {
                        #region Vars
                        CompanyUser CompanyUser = null;
                        #endregion
                        #region Get CompanyUser by id
                        CompanyUser = await UnitOfWork.CompanyUserRepository.GetById(CompanyUserId);
                        #endregion
                        #region check if object is not null
                        if (CompanyUser != null)
                        {
                            CompanyUser.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyUserRepository.Update(CompanyUser);
                            isCompanyUserDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserDeleted;
            }
#endregion
        }
    }




