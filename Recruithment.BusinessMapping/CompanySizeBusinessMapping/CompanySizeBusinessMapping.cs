using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanySizeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanySizeBusinessMapping : BaseBusinessMapping, ICompanySizeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanySizeMapping CompanySizeMapping { get; }
        #endregion

        #region Constructor
        public CompanySizeBusinessMapping(IUnitOfWork unitOfWork, ICompanySizeMapping companySizeMapping)
        {
            UnitOfWork = unitOfWork;
            CompanySizeMapping = companySizeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanySizeReturnDTO></returns>
        public async Task<List<CompanySizeReturnDTO>> GetAllCompanySizes()
        {
            #region Declare Return Var with Intial Value
            List<CompanySizeReturnDTO> allCompanySizes = null;
            #endregion
            try
            {
                #region Vars
                List<CompanySize> CompanySizeList = null;
                #endregion
                CompanySizeList = await UnitOfWork.CompanySizeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanySizeList != null && CompanySizeList.Any())
                {
                    allCompanySizes = CompanySizeMapping.MappingCompanySizeToCompanySizeReturnDTO(CompanySizeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanySizes;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanySize(CompanySizeAddDTO CompanySizeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanySizeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanySize CompanySize = null;
                    #endregion
                    CompanySize = CompanySizeMapping.MappingCompanySizeAddDTOToCompanySize(CompanySizeAddDTO);
                    if (CompanySize != null)
                    {
                        await UnitOfWork.CompanySizeRepository.Insert(CompanySize);
                        isCompanySizeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanySizeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanySizeReturnDTO></returns>
            public async Task<CompanySizeReturnDTO> GetCompanySizeById(int CompanySizeId)
            {
                #region Declare a return type with initial value.
                CompanySizeReturnDTO CompanySize = new CompanySizeReturnDTO();
                #endregion
                try
                {
                    CompanySize companySize = await UnitOfWork.CompanySizeRepository.GetById(CompanySizeId);
                    if (companySize != null)
                    {
                        if (companySize.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanySize = CompanySizeMapping.MappingCompanySizeToCompanySizeReturnDTO(companySize);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanySize;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanySize(CompanySizeUpdateDTO CompanySizeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanySizeUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanySizeUpdateDTO != null)
                    {
                        #region Vars
                        CompanySize CompanySize = null;
                        #endregion
                        #region Get Activity By Id
                        CompanySize = await UnitOfWork.CompanySizeRepository.GetById(CompanySizeUpdateDTO.CompanySizeId);
                        #endregion
                        if (CompanySize != null)
                        {
                            #region  Mapping
                            CompanySize = CompanySizeMapping.MappingCompanySizeupdateDTOToCompanySize(CompanySize ,CompanySizeUpdateDTO);
                            #endregion
                            if (CompanySize != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanySizeRepository.Update(CompanySize);
                                isCompanySizeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanySizeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanySize(int CompanySizeId)
            {
                #region Declare a return type with initial value.
                bool isCompanySizeDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanySizeId > default(int))
                    {
                        #region Vars
                        CompanySize CompanySize = null;
                        #endregion
                        #region Get CompanySize by id
                        CompanySize = await UnitOfWork.CompanySizeRepository.GetById(CompanySizeId);
                        #endregion
                        #region check if object is not null
                        if (CompanySize != null)
                        {
                            CompanySize.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanySizeRepository.Update(CompanySize);
                            isCompanySizeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanySizeDeleted;
            }
#endregion
        }
    }




