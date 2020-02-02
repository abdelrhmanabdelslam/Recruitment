using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerExperienceDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerExperienceAppService : BaseAppService, IJobSeekerExperienceAppService
    {
        #region Properties
        public IJobSeekerExperienceBusinessMapping JobSeekerExperienceBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerExperienceAppService(IJobSeekerExperienceBusinessMapping jobSeekerExperienceBusinessMapping)
        {
            JobSeekerExperienceBusinessMapping = jobSeekerExperienceBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerExperience ActionActivity Logs for All JobSeekerExperiences
        /// </summary>
        /// <returns>List<JobSeekerExperienceReturnDTO></returns>
        public async Task<List<JobSeekerExperienceReturnDTO>> GetAllJobSeekerExperiences()
        {
            #region Declare a return type with initial value.
            List<JobSeekerExperienceReturnDTO> allJobSeekerExperiences = null;
            #endregion
            try
            {
                allJobSeekerExperiences = await JobSeekerExperienceBusinessMapping.GetAllJobSeekerExperiences();
            }
            catch (Exception exception)  {}
            return allJobSeekerExperiences;
        }
        /// <summary>
        /// Add JobSeekerExperience AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerExperience(JobSeekerExperienceAddDTO jobSeekerExperienceAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerExperienceAddDTO != null)
                {
                    isCreated = await JobSeekerExperienceBusinessMapping.AddJobSeekerExperience(jobSeekerExperienceAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerExperience By Id 
        /// </summary>
        /// <returns>JobSeekerExperienceReturnDTO<JobSeekerExperienceReturnDTO></returns>
        public async Task<JobSeekerExperienceReturnDTO> GetJobSeekerExperienceById(int JobSeekerExperienceId)
        {
            #region Declare a return type with initial value.
            JobSeekerExperienceReturnDTO JobSeekerExperience = null;
            #endregion
            try
            {
                if (JobSeekerExperienceId > default(int))
                {
                    JobSeekerExperience = await JobSeekerExperienceBusinessMapping.GetJobSeekerExperienceById(JobSeekerExperienceId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerExperience;
        }
        /// <summary>
        /// Updae JobSeekerExperience AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerExperience(JobSeekerExperienceUpdateDTO jobSeekerExperienceUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerExperienceUpdateDTO != null)
                {
                    isUpdated = await JobSeekerExperienceBusinessMapping.UpdateJobSeekerExperience(jobSeekerExperienceUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerExperience AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerExperience(int JobSeekerExperienceId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerExperienceId > default(int))
                {
                    isDeleted = await JobSeekerExperienceBusinessMapping.DeleteJobSeekerExperience(JobSeekerExperienceId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




