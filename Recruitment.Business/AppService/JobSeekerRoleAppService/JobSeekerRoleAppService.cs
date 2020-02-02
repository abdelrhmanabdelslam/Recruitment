using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerRoleDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerRoleAppService : BaseAppService, IJobSeekerRoleAppService
    {
        #region Properties
        public IJobSeekerRoleBusinessMapping JobSeekerRoleBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerRoleAppService(IJobSeekerRoleBusinessMapping jobSeekerRoleBusinessMapping)
        {
            JobSeekerRoleBusinessMapping = jobSeekerRoleBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerRole ActionActivity Logs for All JobSeekerRoles
        /// </summary>
        /// <returns>List<JobSeekerRoleReturnDTO></returns>
        public async Task<List<JobSeekerRoleReturnDTO>> GetAllJobSeekerRoles()
        {
            #region Declare a return type with initial value.
            List<JobSeekerRoleReturnDTO> allJobSeekerRoles = null;
            #endregion
            try
            {
                allJobSeekerRoles = await JobSeekerRoleBusinessMapping.GetAllJobSeekerRoles();
            }
            catch (Exception exception)  {}
            return allJobSeekerRoles;
        }
        /// <summary>
        /// Add JobSeekerRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerRole(JobSeekerRoleAddDTO jobSeekerRoleAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerRoleAddDTO != null)
                {
                    isCreated = await JobSeekerRoleBusinessMapping.AddJobSeekerRole(jobSeekerRoleAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerRole By Id 
        /// </summary>
        /// <returns>JobSeekerRoleReturnDTO<JobSeekerRoleReturnDTO></returns>
        public async Task<JobSeekerRoleReturnDTO> GetJobSeekerRoleById(int JobSeekerRoleId)
        {
            #region Declare a return type with initial value.
            JobSeekerRoleReturnDTO JobSeekerRole = null;
            #endregion
            try
            {
                if (JobSeekerRoleId > default(int))
                {
                    JobSeekerRole = await JobSeekerRoleBusinessMapping.GetJobSeekerRoleById(JobSeekerRoleId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerRole;
        }
        /// <summary>
        /// Updae JobSeekerRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerRole(JobSeekerRoleUpdateDTO jobSeekerRoleUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerRoleUpdateDTO != null)
                {
                    isUpdated = await JobSeekerRoleBusinessMapping.UpdateJobSeekerRole(jobSeekerRoleUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerRole AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerRole(int JobSeekerRoleId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerRoleId > default(int))
                {
                    isDeleted = await JobSeekerRoleBusinessMapping.DeleteJobSeekerRole(JobSeekerRoleId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




