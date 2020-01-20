using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobRoleAppService : BaseAppService, IJobRoleAppService
    {
        #region Properties
        public IJobRoleBusinessMapping JobRoleBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobRoleAppService(IJobRoleBusinessMapping jobRoleBusinessMapping)
        {
            JobRoleBusinessMapping = jobRoleBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobRole ActionActivity Logs for All JobRoles
        /// </summary>
        /// <returns>List<JobRoleReturnDTO></returns>
        public async Task<List<JobRoleReturnDTO>> GetAllJobRoles()
        {
            #region Declare a return type with initial value.
            List<JobRoleReturnDTO> allJobRoles = null;
            #endregion
            try
            {
                allJobRoles = await JobRoleBusinessMapping.GetAllJobRoles();
            }
            catch (Exception exception)  {}
            return allJobRoles;
        }
        /// <summary>
        /// Add JobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobRole(JobRoleAddDTO jobRoleAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobRoleAddDTO != null)
                {
                    isCreated = await JobRoleBusinessMapping.AddJobRole(jobRoleAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobRole By Id 
        /// </summary>
        /// <returns>JobRoleReturnDTO<JobRoleReturnDTO></returns>
        public async Task<JobRoleReturnDTO> GetJobRoleById(int JobRoleId)
        {
            #region Declare a return type with initial value.
            JobRoleReturnDTO JobRole = null;
            #endregion
            try
            {
                if (JobRoleId > default(int))
                {
                    JobRole = await JobRoleBusinessMapping.GetJobRoleById(JobRoleId);
                }
            }
            catch (Exception exception)  {}
            return JobRole;
        }
        /// <summary>
        /// Updae JobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobRole(JobRoleUpdateDTO jobRoleUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobRoleUpdateDTO != null)
                {
                    isUpdated = await JobRoleBusinessMapping.UpdateJobRole(jobRoleUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobRole AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobRole(int JobRoleId)
        {
            bool isDeleted = false;
            try
            {
                if (JobRoleId > default(int))
                {
                    isDeleted = await JobRoleBusinessMapping.DeleteJobRole(JobRoleId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




