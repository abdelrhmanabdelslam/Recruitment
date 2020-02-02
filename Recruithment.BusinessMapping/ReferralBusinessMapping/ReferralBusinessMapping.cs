using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.ReferralDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class ReferralBusinessMapping : BaseBusinessMapping, IReferralBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IReferralMapping ReferralMapping { get; }
        #endregion

        #region Constructor
        public ReferralBusinessMapping(IUnitOfWork unitOfWork, IReferralMapping referralMapping)
        {
            UnitOfWork = unitOfWork;
            ReferralMapping = referralMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<ReferralReturnDTO></returns>
        public async Task<List<ReferralReturnDTO>> GetAllReferrals()
        {
            #region Declare Return Var with Intial Value
            List<ReferralReturnDTO> allReferrals = null;
            #endregion
            try
            {
                #region Vars
                List<Referral> ReferralList = null;
                #endregion
                ReferralList = await UnitOfWork.ReferralRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (ReferralList != null && ReferralList.Any())
                {
                    allReferrals = ReferralMapping.MappingReferralToReferralReturnDTO(ReferralList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allReferrals;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddReferral(ReferralAddDTO ReferralAddDTO)
            {
                #region Declare a return type with initial value.
                bool isReferralCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Referral Referral = null;
                    #endregion
                    Referral = ReferralMapping.MappingReferralAddDTOToReferral(ReferralAddDTO);
                    if (Referral != null)
                    {
                        await UnitOfWork.ReferralRepository.Insert(Referral);
                        isReferralCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isReferralCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<ReferralReturnDTO></returns>
            public async Task<ReferralReturnDTO> GetReferralById(int ReferralId)
            {
                #region Declare a return type with initial value.
                ReferralReturnDTO Referral = new ReferralReturnDTO();
                #endregion
                try
                {
                    Referral referral = await UnitOfWork.ReferralRepository.GetById(ReferralId);
                    if (referral != null)
                    {
                        if (referral.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Referral = ReferralMapping.MappingReferralToReferralReturnDTO(referral);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Referral;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateReferral(ReferralUpdateDTO ReferralUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isReferralUpdated = default(bool);
                #endregion
                try
                {
                    if (ReferralUpdateDTO != null)
                    {
                        #region Vars
                        Referral Referral = null;
                        #endregion
                        #region Get Activity By Id
                        Referral = await UnitOfWork.ReferralRepository.GetById(ReferralUpdateDTO.ReferralId);
                        #endregion
                        if (Referral != null)
                        {
                            #region  Mapping
                            Referral = ReferralMapping.MappingReferralupdateDTOToReferral(Referral ,ReferralUpdateDTO);
                            #endregion
                            if (Referral != null)
                            {
                                #region  Update Entity
                                UnitOfWork.ReferralRepository.Update(Referral);
                                isReferralUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isReferralUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteReferral(int ReferralId)
            {
                #region Declare a return type with initial value.
                bool isReferralDeleted = default(bool);
                #endregion
                try
                {
                    if (ReferralId > default(int))
                    {
                        #region Vars
                        Referral Referral = null;
                        #endregion
                        #region Get Referral by id
                        Referral = await UnitOfWork.ReferralRepository.GetById(ReferralId);
                        #endregion
                        #region check if object is not null
                        if (Referral != null)
                        {
                            Referral.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.ReferralRepository.Update(Referral);
                            isReferralDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isReferralDeleted;
            }
#endregion
        }
    }




