using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyInformationDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyInformationBusinessMapping : BaseBusinessMapping, ICompanyInformationBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyInformationMapping CompanyInformationMapping { get; }
        #endregion

        #region Constructor
        public CompanyInformationBusinessMapping(IUnitOfWork unitOfWork, ICompanyInformationMapping companyInformationMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyInformationMapping = companyInformationMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyInformationReturnDTO></returns>
        public async Task<List<CompanyInformationReturnDTO>> GetAllCompanyInformations()
        {
            #region Declare Return Var with Intial Value
            List<CompanyInformationReturnDTO> allCompanyInformations = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyInformation> CompanyInformationList = null;
                #endregion
                CompanyInformationList = await UnitOfWork.CompanyInformationRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyInformationList != null && CompanyInformationList.Any())
                {
                    allCompanyInformations = CompanyInformationMapping.MappingCompanyInformationToCompanyInformationReturnDTO(CompanyInformationList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyInformations;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyInformation(CompanyInformationAddDTO CompanyInformationAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyInformationCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyInformation CompanyInformation = null;
                    #endregion
                    CompanyInformation = CompanyInformationMapping.MappingCompanyInformationAddDTOToCompanyInformation(CompanyInformationAddDTO);
                    if (CompanyInformation != null)
                    {
                        await UnitOfWork.CompanyInformationRepository.Insert(CompanyInformation);
                        isCompanyInformationCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyInformationCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyInformationReturnDTO></returns>
            public async Task<CompanyInformationReturnDTO> GetCompanyInformationById(int CompanyInformationId)
            {
                #region Declare a return type with initial value.
                CompanyInformationReturnDTO CompanyInformation = new CompanyInformationReturnDTO();
                #endregion
                try
                {
                    CompanyInformation companyInformation = await UnitOfWork.CompanyInformationRepository.GetById(CompanyInformationId);
                    if (companyInformation != null)
                    {
                        if (companyInformation.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyInformation = CompanyInformationMapping.MappingCompanyInformationToCompanyInformationReturnDTO(companyInformation);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyInformation;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyInformation(CompanyInformationUpdateDTO CompanyInformationUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyInformationUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyInformationUpdateDTO != null)
                    {
                        #region Vars
                        CompanyInformation CompanyInformation = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyInformation = await UnitOfWork.CompanyInformationRepository.GetById(CompanyInformationUpdateDTO.CompanyInformationId);
                        #endregion
                        if (CompanyInformation != null)
                        {
                            #region  Mapping
                            CompanyInformation = CompanyInformationMapping.MappingCompanyInformationupdateDTOToCompanyInformation(CompanyInformation ,CompanyInformationUpdateDTO);
                            #endregion
                            if (CompanyInformation != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyInformationRepository.Update(CompanyInformation);
                                isCompanyInformationUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyInformationUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyInformation(int CompanyInformationId)
            {
                #region Declare a return type with initial value.
                bool isCompanyInformationDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyInformationId > default(int))
                    {
                        #region Vars
                        CompanyInformation CompanyInformation = null;
                        #endregion
                        #region Get CompanyInformation by id
                        CompanyInformation = await UnitOfWork.CompanyInformationRepository.GetById(CompanyInformationId);
                        #endregion
                        #region check if object is not null
                        if (CompanyInformation != null)
                        {
                            CompanyInformation.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyInformationRepository.Update(CompanyInformation);
                            isCompanyInformationDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyInformationDeleted;
            }
#endregion
        }
    }




