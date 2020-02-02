using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerApplyStatusAppService : BaseAppService, IJobSeekerApplyStatusAppService
    {
        #region Properties
        public IJobSeekerApplyStatusBusinessMapping JobSeekerApplyStatusBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerApplyStatusAppService(IJobSeekerApplyStatusBusinessMapping jobSeekerApplyStatusBusinessMapping)
        {
            JobSeekerApplyStatusBusinessMapping = jobSeekerApplyStatusBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerApplyStatus ActionActivity Logs for All JobSeekerApplyStatuss
        /// </summary>
        /// <returns>List<JobSeekerApplyStatusReturnDTO></returns>
        public async Task<List<JobSeekerApplyStatusReturnDTO>> GetAllJobSeekerApplyStatuss()
        {
            #region Declare a return type with initial value.
            List<JobSeekerApplyStatusReturnDTO> allJobSeekerApplyStatuss = null;
            #endregion
            try
            {
                allJobSeekerApplyStatuss = await JobSeekerApplyStatusBusinessMapping.GetAllJobSeekerApplyStatuss();
            }
            catch (Exception exception)  {}
            return allJobSeekerApplyStatuss;
        }
        /// <summary>
        /// Add JobSeekerApplyStatus AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO jobSeekerApplyStatusAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerApplyStatusAddDTO != null)
                {
                    isCreated = await JobSeekerApplyStatusBusinessMapping.AddJobSeekerApplyStatus(jobSeekerApplyStatusAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerApplyStatus By Id 
        /// </summary>
        /// <returns>JobSeekerApplyStatusReturnDTO<JobSeekerApplyStatusReturnDTO></returns>
        public async Task<JobSeekerApplyStatusReturnDTO> GetJobSeekerApplyStatusById(int JobSeekerApplyStatusId)
        {
            #region Declare a return type with initial value.
            JobSeekerApplyStatusReturnDTO JobSeekerApplyStatus = null;
            #endregion
            try
            {
                if (JobSeekerApplyStatusId > default(int))
                {
                    JobSeekerApplyStatus = await JobSeekerApplyStatusBusinessMapping.GetJobSeekerApplyStatusById(JobSeekerApplyStatusId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerApplyStatus;
        }
        /// <summary>
        /// Updae JobSeekerApplyStatus AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerApplyStatus(JobSeekerApplyStatusUpdateDTO jobSeekerApplyStatusUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerApplyStatusUpdateDTO != null)
                {
                    isUpdated = await JobSeekerApplyStatusBusinessMapping.UpdateJobSeekerApplyStatus(jobSeekerApplyStatusUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerApplyStatus AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerApplyStatus(int JobSeekerApplyStatusId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerApplyStatusId > default(int))
                {
                    isDeleted = await JobSeekerApplyStatusBusinessMapping.DeleteJobSeekerApplyStatus(JobSeekerApplyStatusId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




