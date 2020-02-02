using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerSkillsDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerSkillsAppService : BaseAppService, IJobSeekerSkillsAppService
    {
        #region Properties
        public IJobSeekerSkillsBusinessMapping JobSeekerSkillsBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerSkillsAppService(IJobSeekerSkillsBusinessMapping jobSeekerSkillsBusinessMapping)
        {
            JobSeekerSkillsBusinessMapping = jobSeekerSkillsBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerSkills ActionActivity Logs for All JobSeekerSkillss
        /// </summary>
        /// <returns>List<JobSeekerSkillsReturnDTO></returns>
        public async Task<List<JobSeekerSkillsReturnDTO>> GetAllJobSeekerSkillss()
        {
            #region Declare a return type with initial value.
            List<JobSeekerSkillsReturnDTO> allJobSeekerSkillss = null;
            #endregion
            try
            {
                allJobSeekerSkillss = await JobSeekerSkillsBusinessMapping.GetAllJobSeekerSkillss();
            }
            catch (Exception exception)  {}
            return allJobSeekerSkillss;
        }
        /// <summary>
        /// Add JobSeekerSkills AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerSkills(JobSeekerSkillsAddDTO jobSeekerSkillsAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerSkillsAddDTO != null)
                {
                    isCreated = await JobSeekerSkillsBusinessMapping.AddJobSeekerSkills(jobSeekerSkillsAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerSkills By Id 
        /// </summary>
        /// <returns>JobSeekerSkillsReturnDTO<JobSeekerSkillsReturnDTO></returns>
        public async Task<JobSeekerSkillsReturnDTO> GetJobSeekerSkillsById(int JobSeekerSkillsId)
        {
            #region Declare a return type with initial value.
            JobSeekerSkillsReturnDTO JobSeekerSkills = null;
            #endregion
            try
            {
                if (JobSeekerSkillsId > default(int))
                {
                    JobSeekerSkills = await JobSeekerSkillsBusinessMapping.GetJobSeekerSkillsById(JobSeekerSkillsId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerSkills;
        }
        /// <summary>
        /// Updae JobSeekerSkills AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerSkills(JobSeekerSkillsUpdateDTO jobSeekerSkillsUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerSkillsUpdateDTO != null)
                {
                    isUpdated = await JobSeekerSkillsBusinessMapping.UpdateJobSeekerSkills(jobSeekerSkillsUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerSkills AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerSkills(int JobSeekerSkillsId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerSkillsId > default(int))
                {
                    isDeleted = await JobSeekerSkillsBusinessMapping.DeleteJobSeekerSkills(JobSeekerSkillsId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




