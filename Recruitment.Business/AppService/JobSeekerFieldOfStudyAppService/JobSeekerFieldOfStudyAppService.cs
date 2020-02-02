using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerFieldOfStudyAppService : BaseAppService, IJobSeekerFieldOfStudyAppService
    {
        #region Properties
        public IJobSeekerFieldOfStudyBusinessMapping JobSeekerFieldOfStudyBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerFieldOfStudyAppService(IJobSeekerFieldOfStudyBusinessMapping jobSeekerFieldOfStudyBusinessMapping)
        {
            JobSeekerFieldOfStudyBusinessMapping = jobSeekerFieldOfStudyBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerFieldOfStudy ActionActivity Logs for All JobSeekerFieldOfStudys
        /// </summary>
        /// <returns>List<JobSeekerFieldOfStudyReturnDTO></returns>
        public async Task<List<JobSeekerFieldOfStudyReturnDTO>> GetAllJobSeekerFieldOfStudys()
        {
            #region Declare a return type with initial value.
            List<JobSeekerFieldOfStudyReturnDTO> allJobSeekerFieldOfStudys = null;
            #endregion
            try
            {
                allJobSeekerFieldOfStudys = await JobSeekerFieldOfStudyBusinessMapping.GetAllJobSeekerFieldOfStudys();
            }
            catch (Exception exception)  {}
            return allJobSeekerFieldOfStudys;
        }
        /// <summary>
        /// Add JobSeekerFieldOfStudy AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO jobSeekerFieldOfStudyAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerFieldOfStudyAddDTO != null)
                {
                    isCreated = await JobSeekerFieldOfStudyBusinessMapping.AddJobSeekerFieldOfStudy(jobSeekerFieldOfStudyAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerFieldOfStudy By Id 
        /// </summary>
        /// <returns>JobSeekerFieldOfStudyReturnDTO<JobSeekerFieldOfStudyReturnDTO></returns>
        public async Task<JobSeekerFieldOfStudyReturnDTO> GetJobSeekerFieldOfStudyById(int JobSeekerFieldOfStudyId)
        {
            #region Declare a return type with initial value.
            JobSeekerFieldOfStudyReturnDTO JobSeekerFieldOfStudy = null;
            #endregion
            try
            {
                if (JobSeekerFieldOfStudyId > default(int))
                {
                    JobSeekerFieldOfStudy = await JobSeekerFieldOfStudyBusinessMapping.GetJobSeekerFieldOfStudyById(JobSeekerFieldOfStudyId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerFieldOfStudy;
        }
        /// <summary>
        /// Updae JobSeekerFieldOfStudy AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO jobSeekerFieldOfStudyUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerFieldOfStudyUpdateDTO != null)
                {
                    isUpdated = await JobSeekerFieldOfStudyBusinessMapping.UpdateJobSeekerFieldOfStudy(jobSeekerFieldOfStudyUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerFieldOfStudy AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerFieldOfStudy(int JobSeekerFieldOfStudyId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerFieldOfStudyId > default(int))
                {
                    isDeleted = await JobSeekerFieldOfStudyBusinessMapping.DeleteJobSeekerFieldOfStudy(JobSeekerFieldOfStudyId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




