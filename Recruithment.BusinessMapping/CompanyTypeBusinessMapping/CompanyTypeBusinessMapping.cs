using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyTypeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyTypeBusinessMapping : BaseBusinessMapping, ICompanyTypeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyTypeMapping CompanyTypeMapping { get; }
        #endregion

        #region Constructor
        public CompanyTypeBusinessMapping(IUnitOfWork unitOfWork, ICompanyTypeMapping companyTypeMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyTypeMapping = companyTypeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyTypeReturnDTO></returns>
        public async Task<List<CompanyTypeReturnDTO>> GetAllCompanyTypes()
        {
            #region Declare Return Var with Intial Value
            List<CompanyTypeReturnDTO> allCompanyTypes = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyType> CompanyTypeList = null;
                #endregion
                CompanyTypeList = await UnitOfWork.CompanyTypeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyTypeList != null && CompanyTypeList.Any())
                {
                    allCompanyTypes = CompanyTypeMapping.MappingCompanyTypeToCompanyTypeReturnDTO(CompanyTypeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyTypes;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyType(CompanyTypeAddDTO CompanyTypeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyTypeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyType CompanyType = null;
                    #endregion
                    CompanyType = CompanyTypeMapping.MappingCompanyTypeAddDTOToCompanyType(CompanyTypeAddDTO);
                    if (CompanyType != null)
                    {
                        await UnitOfWork.CompanyTypeRepository.Insert(CompanyType);
                        isCompanyTypeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyTypeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyTypeReturnDTO></returns>
            public async Task<CompanyTypeReturnDTO> GetCompanyTypeById(int CompanyTypeId)
            {
                #region Declare a return type with initial value.
                CompanyTypeReturnDTO CompanyType = new CompanyTypeReturnDTO();
                #endregion
                try
                {
                    CompanyType companyType = await UnitOfWork.CompanyTypeRepository.GetById(CompanyTypeId);
                    if (companyType != null)
                    {
                        if (companyType.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyType = CompanyTypeMapping.MappingCompanyTypeToCompanyTypeReturnDTO(companyType);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyType;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyType(CompanyTypeUpdateDTO CompanyTypeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyTypeUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyTypeUpdateDTO != null)
                    {
                        #region Vars
                        CompanyType CompanyType = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyType = await UnitOfWork.CompanyTypeRepository.GetById(CompanyTypeUpdateDTO.CompanyTypeId);
                        #endregion
                        if (CompanyType != null)
                        {
                            #region  Mapping
                            CompanyType = CompanyTypeMapping.MappingCompanyTypeupdateDTOToCompanyType(CompanyType ,CompanyTypeUpdateDTO);
                            #endregion
                            if (CompanyType != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyTypeRepository.Update(CompanyType);
                                isCompanyTypeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyTypeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyType(int CompanyTypeId)
            {
                #region Declare a return type with initial value.
                bool isCompanyTypeDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyTypeId > default(int))
                    {
                        #region Vars
                        CompanyType CompanyType = null;
                        #endregion
                        #region Get CompanyType by id
                        CompanyType = await UnitOfWork.CompanyTypeRepository.GetById(CompanyTypeId);
                        #endregion
                        #region check if object is not null
                        if (CompanyType != null)
                        {
                            CompanyType.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyTypeRepository.Update(CompanyType);
                            isCompanyTypeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyTypeDeleted;
            }
#endregion
        }
    }




