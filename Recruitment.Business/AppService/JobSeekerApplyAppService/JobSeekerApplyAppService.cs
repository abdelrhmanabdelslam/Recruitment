using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerApplyDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerApplyAppService : BaseAppService, IJobSeekerApplyAppService
    {
        #region Properties
        public IJobSeekerApplyBusinessMapping JobSeekerApplyBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerApplyAppService(IJobSeekerApplyBusinessMapping jobSeekerApplyBusinessMapping)
        {
            JobSeekerApplyBusinessMapping = jobSeekerApplyBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerApply ActionActivity Logs for All JobSeekerApplys
        /// </summary>
        /// <returns>List<JobSeekerApplyReturnDTO></returns>
        public async Task<List<JobSeekerApplyReturnDTO>> GetAllJobSeekerApplys()
        {
            #region Declare a return type with initial value.
            List<JobSeekerApplyReturnDTO> allJobSeekerApplys = null;
            #endregion
            try
            {
                allJobSeekerApplys = await JobSeekerApplyBusinessMapping.GetAllJobSeekerApplys();
            }
            catch (Exception exception)  {}
            return allJobSeekerApplys;
        }
        /// <summary>
        /// Add JobSeekerApply AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerApply(JobSeekerApplyAddDTO jobSeekerApplyAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerApplyAddDTO != null)
                {
                    isCreated = await JobSeekerApplyBusinessMapping.AddJobSeekerApply(jobSeekerApplyAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerApply By Id 
        /// </summary>
        /// <returns>JobSeekerApplyReturnDTO<JobSeekerApplyReturnDTO></returns>
        public async Task<JobSeekerApplyReturnDTO> GetJobSeekerApplyById(int JobSeekerApplyId)
        {
            #region Declare a return type with initial value.
            JobSeekerApplyReturnDTO JobSeekerApply = null;
            #endregion
            try
            {
                if (JobSeekerApplyId > default(int))
                {
                    JobSeekerApply = await JobSeekerApplyBusinessMapping.GetJobSeekerApplyById(JobSeekerApplyId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerApply;
        }
        /// <summary>
        /// Updae JobSeekerApply AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerApply(JobSeekerApplyUpdateDTO jobSeekerApplyUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerApplyUpdateDTO != null)
                {
                    isUpdated = await JobSeekerApplyBusinessMapping.UpdateJobSeekerApply(jobSeekerApplyUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerApply AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerApply(int JobSeekerApplyId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerApplyId > default(int))
                {
                    isDeleted = await JobSeekerApplyBusinessMapping.DeleteJobSeekerApply(JobSeekerApplyId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




