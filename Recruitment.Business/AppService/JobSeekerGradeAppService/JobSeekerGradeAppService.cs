using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerGradeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerGradeAppService : BaseAppService, IJobSeekerGradeAppService
    {
        #region Properties
        public IJobSeekerGradeBusinessMapping JobSeekerGradeBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerGradeAppService(IJobSeekerGradeBusinessMapping jobSeekerGradeBusinessMapping)
        {
            JobSeekerGradeBusinessMapping = jobSeekerGradeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerGrade ActionActivity Logs for All JobSeekerGrades
        /// </summary>
        /// <returns>List<JobSeekerGradeReturnDTO></returns>
        public async Task<List<JobSeekerGradeReturnDTO>> GetAllJobSeekerGrades()
        {
            #region Declare a return type with initial value.
            List<JobSeekerGradeReturnDTO> allJobSeekerGrades = null;
            #endregion
            try
            {
                allJobSeekerGrades = await JobSeekerGradeBusinessMapping.GetAllJobSeekerGrades();
            }
            catch (Exception exception)  {}
            return allJobSeekerGrades;
        }
        /// <summary>
        /// Add JobSeekerGrade AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerGrade(JobSeekerGradeAddDTO jobSeekerGradeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerGradeAddDTO != null)
                {
                    isCreated = await JobSeekerGradeBusinessMapping.AddJobSeekerGrade(jobSeekerGradeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerGrade By Id 
        /// </summary>
        /// <returns>JobSeekerGradeReturnDTO<JobSeekerGradeReturnDTO></returns>
        public async Task<JobSeekerGradeReturnDTO> GetJobSeekerGradeById(int JobSeekerGradeId)
        {
            #region Declare a return type with initial value.
            JobSeekerGradeReturnDTO JobSeekerGrade = null;
            #endregion
            try
            {
                if (JobSeekerGradeId > default(int))
                {
                    JobSeekerGrade = await JobSeekerGradeBusinessMapping.GetJobSeekerGradeById(JobSeekerGradeId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerGrade;
        }
        /// <summary>
        /// Updae JobSeekerGrade AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerGrade(JobSeekerGradeUpdateDTO jobSeekerGradeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerGradeUpdateDTO != null)
                {
                    isUpdated = await JobSeekerGradeBusinessMapping.UpdateJobSeekerGrade(jobSeekerGradeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerGrade AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerGrade(int JobSeekerGradeId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerGradeId > default(int))
                {
                    isDeleted = await JobSeekerGradeBusinessMapping.DeleteJobSeekerGrade(JobSeekerGradeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




