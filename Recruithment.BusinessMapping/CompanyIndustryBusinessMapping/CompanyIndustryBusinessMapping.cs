using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyIndustryDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyIndustryBusinessMapping : BaseBusinessMapping, ICompanyIndustryBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyIndustryMapping CompanyIndustryMapping { get; }
        #endregion

        #region Constructor
        public CompanyIndustryBusinessMapping(IUnitOfWork unitOfWork, ICompanyIndustryMapping companyIndustryMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyIndustryMapping = companyIndustryMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyIndustryReturnDTO></returns>
        public async Task<List<CompanyIndustryReturnDTO>> GetAllCompanyIndustrys()
        {
            #region Declare Return Var with Intial Value
            List<CompanyIndustryReturnDTO> allCompanyIndustrys = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyIndustry> CompanyIndustryList = null;
                #endregion
                CompanyIndustryList = await UnitOfWork.CompanyIndustryRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyIndustryList != null && CompanyIndustryList.Any())
                {
                    allCompanyIndustrys = CompanyIndustryMapping.MappingCompanyIndustryToCompanyIndustryReturnDTO(CompanyIndustryList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyIndustrys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyIndustry(CompanyIndustryAddDTO CompanyIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyIndustryCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyIndustry CompanyIndustry = null;
                    #endregion
                    CompanyIndustry = CompanyIndustryMapping.MappingCompanyIndustryAddDTOToCompanyIndustry(CompanyIndustryAddDTO);
                    if (CompanyIndustry != null)
                    {
                        await UnitOfWork.CompanyIndustryRepository.Insert(CompanyIndustry);
                        isCompanyIndustryCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyIndustryCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyIndustryReturnDTO></returns>
            public async Task<CompanyIndustryReturnDTO> GetCompanyIndustryById(int CompanyIndustryId)
            {
                #region Declare a return type with initial value.
                CompanyIndustryReturnDTO CompanyIndustry = new CompanyIndustryReturnDTO();
                #endregion
                try
                {
                    CompanyIndustry companyIndustry = await UnitOfWork.CompanyIndustryRepository.GetById(CompanyIndustryId);
                    if (companyIndustry != null)
                    {
                        if (companyIndustry.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyIndustry = CompanyIndustryMapping.MappingCompanyIndustryToCompanyIndustryReturnDTO(companyIndustry);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyIndustry;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyIndustry(CompanyIndustryUpdateDTO CompanyIndustryUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyIndustryUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyIndustryUpdateDTO != null)
                    {
                        #region Vars
                        CompanyIndustry CompanyIndustry = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyIndustry = await UnitOfWork.CompanyIndustryRepository.GetById(CompanyIndustryUpdateDTO.CompanyIndustryId);
                        #endregion
                        if (CompanyIndustry != null)
                        {
                            #region  Mapping
                            CompanyIndustry = CompanyIndustryMapping.MappingCompanyIndustryupdateDTOToCompanyIndustry(CompanyIndustry ,CompanyIndustryUpdateDTO);
                            #endregion
                            if (CompanyIndustry != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyIndustryRepository.Update(CompanyIndustry);
                                isCompanyIndustryUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyIndustryUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyIndustry(int CompanyIndustryId)
            {
                #region Declare a return type with initial value.
                bool isCompanyIndustryDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyIndustryId > default(int))
                    {
                        #region Vars
                        CompanyIndustry CompanyIndustry = null;
                        #endregion
                        #region Get CompanyIndustry by id
                        CompanyIndustry = await UnitOfWork.CompanyIndustryRepository.GetById(CompanyIndustryId);
                        #endregion
                        #region check if object is not null
                        if (CompanyIndustry != null)
                        {
                            CompanyIndustry.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyIndustryRepository.Update(CompanyIndustry);
                            isCompanyIndustryDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyIndustryDeleted;
            }
#endregion
        }
    }




