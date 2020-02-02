using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.ReferralDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class ReferralAppService : BaseAppService, IReferralAppService
    {
        #region Properties
        public IReferralBusinessMapping ReferralBusinessMapping { get; }
        #endregion

        #region Constructor
        public ReferralAppService(IReferralBusinessMapping referralBusinessMapping)
        {
            ReferralBusinessMapping = referralBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Referral ActionActivity Logs for All Referrals
        /// </summary>
        /// <returns>List<ReferralReturnDTO></returns>
        public async Task<List<ReferralReturnDTO>> GetAllReferrals()
        {
            #region Declare a return type with initial value.
            List<ReferralReturnDTO> allReferrals = null;
            #endregion
            try
            {
                allReferrals = await ReferralBusinessMapping.GetAllReferrals();
            }
            catch (Exception exception)  {}
            return allReferrals;
        }
        /// <summary>
        /// Add Referral AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddReferral(ReferralAddDTO referralAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (referralAddDTO != null)
                {
                    isCreated = await ReferralBusinessMapping.AddReferral(referralAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Referral By Id 
        /// </summary>
        /// <returns>ReferralReturnDTO<ReferralReturnDTO></returns>
        public async Task<ReferralReturnDTO> GetReferralById(int ReferralId)
        {
            #region Declare a return type with initial value.
            ReferralReturnDTO Referral = null;
            #endregion
            try
            {
                if (ReferralId > default(int))
                {
                    Referral = await ReferralBusinessMapping.GetReferralById(ReferralId);
                }
            }
            catch (Exception exception)  {}
            return Referral;
        }
        /// <summary>
        /// Updae Referral AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateReferral(ReferralUpdateDTO referralUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (referralUpdateDTO != null)
                {
                    isUpdated = await ReferralBusinessMapping.UpdateReferral(referralUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Referral AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteReferral(int ReferralId)
        {
            bool isDeleted = false;
            try
            {
                if (ReferralId > default(int))
                {
                    isDeleted = await ReferralBusinessMapping.DeleteReferral(ReferralId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




