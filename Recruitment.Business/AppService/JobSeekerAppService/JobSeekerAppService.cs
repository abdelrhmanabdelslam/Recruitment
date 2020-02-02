using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerAppService : BaseAppService, IJobSeekerAppService
    {
        #region Properties
        public IJobSeekerBusinessMapping JobSeekerBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerAppService(IJobSeekerBusinessMapping jobSeekerBusinessMapping)
        {
            JobSeekerBusinessMapping = jobSeekerBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeeker ActionActivity Logs for All JobSeekers
        /// </summary>
        /// <returns>List<JobSeekerReturnDTO></returns>
        public async Task<List<JobSeekerReturnDTO>> GetAllJobSeekers()
        {
            #region Declare a return type with initial value.
            List<JobSeekerReturnDTO> allJobSeekers = null;
            #endregion
            try
            {
                allJobSeekers = await JobSeekerBusinessMapping.GetAllJobSeekers();
            }
            catch (Exception exception)  {}
            return allJobSeekers;
        }
        /// <summary>
        /// Add JobSeeker AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeeker(JobSeekerAddDTO jobSeekerAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerAddDTO != null)
                {
                    isCreated = await JobSeekerBusinessMapping.AddJobSeeker(jobSeekerAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeeker By Id 
        /// </summary>
        /// <returns>JobSeekerReturnDTO<JobSeekerReturnDTO></returns>
        public async Task<JobSeekerReturnDTO> GetJobSeekerById(int JobSeekerId)
        {
            #region Declare a return type with initial value.
            JobSeekerReturnDTO JobSeeker = null;
            #endregion
            try
            {
                if (JobSeekerId > default(int))
                {
                    JobSeeker = await JobSeekerBusinessMapping.GetJobSeekerById(JobSeekerId);
                }
            }
            catch (Exception exception)  {}
            return JobSeeker;
        }
        /// <summary>
        /// Updae JobSeeker AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeeker(JobSeekerUpdateDTO jobSeekerUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerUpdateDTO != null)
                {
                    isUpdated = await JobSeekerBusinessMapping.UpdateJobSeeker(jobSeekerUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeeker AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeeker(int JobSeekerId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerId > default(int))
                {
                    isDeleted = await JobSeekerBusinessMapping.DeleteJobSeeker(JobSeekerId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




