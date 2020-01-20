using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyOnlinePresenceBusinessMapping : BaseBusinessMapping, ICompanyOnlinePresenceBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyOnlinePresenceMapping CompanyOnlinePresenceMapping { get; }
        #endregion

        #region Constructor
        public CompanyOnlinePresenceBusinessMapping(IUnitOfWork unitOfWork, ICompanyOnlinePresenceMapping companyOnlinePresenceMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyOnlinePresenceMapping = companyOnlinePresenceMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyOnlinePresenceReturnDTO></returns>
        public async Task<List<CompanyOnlinePresenceReturnDTO>> GetAllCompanyOnlinePresences()
        {
            #region Declare Return Var with Intial Value
            List<CompanyOnlinePresenceReturnDTO> allCompanyOnlinePresences = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyOnlinePresence> CompanyOnlinePresenceList = null;
                #endregion
                CompanyOnlinePresenceList = await UnitOfWork.CompanyOnlinePresenceRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyOnlinePresenceList != null && CompanyOnlinePresenceList.Any())
                {
                    allCompanyOnlinePresences = CompanyOnlinePresenceMapping.MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(CompanyOnlinePresenceList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyOnlinePresences;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyOnlinePresence(CompanyOnlinePresenceAddDTO CompanyOnlinePresenceAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyOnlinePresenceCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyOnlinePresence CompanyOnlinePresence = null;
                    #endregion
                    CompanyOnlinePresence = CompanyOnlinePresenceMapping.MappingCompanyOnlinePresenceAddDTOToCompanyOnlinePresence(CompanyOnlinePresenceAddDTO);
                    if (CompanyOnlinePresence != null)
                    {
                        await UnitOfWork.CompanyOnlinePresenceRepository.Insert(CompanyOnlinePresence);
                        isCompanyOnlinePresenceCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyOnlinePresenceCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyOnlinePresenceReturnDTO></returns>
            public async Task<CompanyOnlinePresenceReturnDTO> GetCompanyOnlinePresenceById(int CompanyOnlinePresenceId)
            {
                #region Declare a return type with initial value.
                CompanyOnlinePresenceReturnDTO CompanyOnlinePresence = new CompanyOnlinePresenceReturnDTO();
                #endregion
                try
                {
                    CompanyOnlinePresence companyOnlinePresence = await UnitOfWork.CompanyOnlinePresenceRepository.GetById(CompanyOnlinePresenceId);
                    if (companyOnlinePresence != null)
                    {
                        if (companyOnlinePresence.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyOnlinePresence = CompanyOnlinePresenceMapping.MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(companyOnlinePresence);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyOnlinePresence;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyOnlinePresence(CompanyOnlinePresenceUpdateDTO CompanyOnlinePresenceUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyOnlinePresenceUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyOnlinePresenceUpdateDTO != null)
                    {
                        #region Vars
                        CompanyOnlinePresence CompanyOnlinePresence = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyOnlinePresence = await UnitOfWork.CompanyOnlinePresenceRepository.GetById(CompanyOnlinePresenceUpdateDTO.CompanyOnlinePresenceId);
                        #endregion
                        if (CompanyOnlinePresence != null)
                        {
                            #region  Mapping
                            CompanyOnlinePresence = CompanyOnlinePresenceMapping.MappingCompanyOnlinePresenceupdateDTOToCompanyOnlinePresence(CompanyOnlinePresence ,CompanyOnlinePresenceUpdateDTO);
                            #endregion
                            if (CompanyOnlinePresence != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyOnlinePresenceRepository.Update(CompanyOnlinePresence);
                                isCompanyOnlinePresenceUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyOnlinePresenceUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyOnlinePresence(int CompanyOnlinePresenceId)
            {
                #region Declare a return type with initial value.
                bool isCompanyOnlinePresenceDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyOnlinePresenceId > default(int))
                    {
                        #region Vars
                        CompanyOnlinePresence CompanyOnlinePresence = null;
                        #endregion
                        #region Get CompanyOnlinePresence by id
                        CompanyOnlinePresence = await UnitOfWork.CompanyOnlinePresenceRepository.GetById(CompanyOnlinePresenceId);
                        #endregion
                        #region check if object is not null
                        if (CompanyOnlinePresence != null)
                        {
                            CompanyOnlinePresence.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyOnlinePresenceRepository.Update(CompanyOnlinePresence);
                            isCompanyOnlinePresenceDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyOnlinePresenceDeleted;
            }
#endregion
        }
    }




