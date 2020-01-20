using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyUserTypeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyUserTypeBusinessMapping : BaseBusinessMapping, ICompanyUserTypeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyUserTypeMapping CompanyUserTypeMapping { get; }
        #endregion

        #region Constructor
        public CompanyUserTypeBusinessMapping(IUnitOfWork unitOfWork, ICompanyUserTypeMapping companyUserTypeMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyUserTypeMapping = companyUserTypeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyUserTypeReturnDTO></returns>
        public async Task<List<CompanyUserTypeReturnDTO>> GetAllCompanyUserTypes()
        {
            #region Declare Return Var with Intial Value
            List<CompanyUserTypeReturnDTO> allCompanyUserTypes = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyUserType> CompanyUserTypeList = null;
                #endregion
                CompanyUserTypeList = await UnitOfWork.CompanyUserTypeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyUserTypeList != null && CompanyUserTypeList.Any())
                {
                    allCompanyUserTypes = CompanyUserTypeMapping.MappingCompanyUserTypeToCompanyUserTypeReturnDTO(CompanyUserTypeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyUserTypes;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyUserType(CompanyUserTypeAddDTO CompanyUserTypeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserTypeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyUserType CompanyUserType = null;
                    #endregion
                    CompanyUserType = CompanyUserTypeMapping.MappingCompanyUserTypeAddDTOToCompanyUserType(CompanyUserTypeAddDTO);
                    if (CompanyUserType != null)
                    {
                        await UnitOfWork.CompanyUserTypeRepository.Insert(CompanyUserType);
                        isCompanyUserTypeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserTypeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyUserTypeReturnDTO></returns>
            public async Task<CompanyUserTypeReturnDTO> GetCompanyUserTypeById(int CompanyUserTypeId)
            {
                #region Declare a return type with initial value.
                CompanyUserTypeReturnDTO CompanyUserType = new CompanyUserTypeReturnDTO();
                #endregion
                try
                {
                    CompanyUserType companyUserType = await UnitOfWork.CompanyUserTypeRepository.GetById(CompanyUserTypeId);
                    if (companyUserType != null)
                    {
                        if (companyUserType.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyUserType = CompanyUserTypeMapping.MappingCompanyUserTypeToCompanyUserTypeReturnDTO(companyUserType);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyUserType;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyUserType(CompanyUserTypeUpdateDTO CompanyUserTypeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserTypeUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyUserTypeUpdateDTO != null)
                    {
                        #region Vars
                        CompanyUserType CompanyUserType = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyUserType = await UnitOfWork.CompanyUserTypeRepository.GetById(CompanyUserTypeUpdateDTO.CompanyUserTypeId);
                        #endregion
                        if (CompanyUserType != null)
                        {
                            #region  Mapping
                            CompanyUserType = CompanyUserTypeMapping.MappingCompanyUserTypeupdateDTOToCompanyUserType(CompanyUserType ,CompanyUserTypeUpdateDTO);
                            #endregion
                            if (CompanyUserType != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyUserTypeRepository.Update(CompanyUserType);
                                isCompanyUserTypeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserTypeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyUserType(int CompanyUserTypeId)
            {
                #region Declare a return type with initial value.
                bool isCompanyUserTypeDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyUserTypeId > default(int))
                    {
                        #region Vars
                        CompanyUserType CompanyUserType = null;
                        #endregion
                        #region Get CompanyUserType by id
                        CompanyUserType = await UnitOfWork.CompanyUserTypeRepository.GetById(CompanyUserTypeId);
                        #endregion
                        #region check if object is not null
                        if (CompanyUserType != null)
                        {
                            CompanyUserType.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyUserTypeRepository.Update(CompanyUserType);
                            isCompanyUserTypeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyUserTypeDeleted;
            }
#endregion
        }
    }




