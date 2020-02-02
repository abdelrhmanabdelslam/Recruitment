using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerTypeOfJobAppService : BaseAppService, IJobSeekerTypeOfJobAppService
    {
        #region Properties
        public IJobSeekerTypeOfJobBusinessMapping JobSeekerTypeOfJobBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerTypeOfJobAppService(IJobSeekerTypeOfJobBusinessMapping jobSeekerTypeOfJobBusinessMapping)
        {
            JobSeekerTypeOfJobBusinessMapping = jobSeekerTypeOfJobBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerTypeOfJob ActionActivity Logs for All JobSeekerTypeOfJobs
        /// </summary>
        /// <returns>List<JobSeekerTypeOfJobReturnDTO></returns>
        public async Task<List<JobSeekerTypeOfJobReturnDTO>> GetAllJobSeekerTypeOfJobs()
        {
            #region Declare a return type with initial value.
            List<JobSeekerTypeOfJobReturnDTO> allJobSeekerTypeOfJobs = null;
            #endregion
            try
            {
                allJobSeekerTypeOfJobs = await JobSeekerTypeOfJobBusinessMapping.GetAllJobSeekerTypeOfJobs();
            }
            catch (Exception exception)  {}
            return allJobSeekerTypeOfJobs;
        }
        /// <summary>
        /// Add JobSeekerTypeOfJob AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO jobSeekerTypeOfJobAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerTypeOfJobAddDTO != null)
                {
                    isCreated = await JobSeekerTypeOfJobBusinessMapping.AddJobSeekerTypeOfJob(jobSeekerTypeOfJobAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerTypeOfJob By Id 
        /// </summary>
        /// <returns>JobSeekerTypeOfJobReturnDTO<JobSeekerTypeOfJobReturnDTO></returns>
        public async Task<JobSeekerTypeOfJobReturnDTO> GetJobSeekerTypeOfJobById(int JobSeekerTypeOfJobId)
        {
            #region Declare a return type with initial value.
            JobSeekerTypeOfJobReturnDTO JobSeekerTypeOfJob = null;
            #endregion
            try
            {
                if (JobSeekerTypeOfJobId > default(int))
                {
                    JobSeekerTypeOfJob = await JobSeekerTypeOfJobBusinessMapping.GetJobSeekerTypeOfJobById(JobSeekerTypeOfJobId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerTypeOfJob;
        }
        /// <summary>
        /// Updae JobSeekerTypeOfJob AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO jobSeekerTypeOfJobUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerTypeOfJobUpdateDTO != null)
                {
                    isUpdated = await JobSeekerTypeOfJobBusinessMapping.UpdateJobSeekerTypeOfJob(jobSeekerTypeOfJobUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerTypeOfJob AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerTypeOfJob(int JobSeekerTypeOfJobId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerTypeOfJobId > default(int))
                {
                    isDeleted = await JobSeekerTypeOfJobBusinessMapping.DeleteJobSeekerTypeOfJob(JobSeekerTypeOfJobId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




