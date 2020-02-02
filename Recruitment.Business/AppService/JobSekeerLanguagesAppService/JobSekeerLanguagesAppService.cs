using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSekeerLanguagesAppService : BaseAppService, IJobSekeerLanguagesAppService
    {
        #region Properties
        public IJobSekeerLanguagesBusinessMapping JobSekeerLanguagesBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSekeerLanguagesAppService(IJobSekeerLanguagesBusinessMapping jobSekeerLanguagesBusinessMapping)
        {
            JobSekeerLanguagesBusinessMapping = jobSekeerLanguagesBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSekeerLanguages ActionActivity Logs for All JobSekeerLanguagess
        /// </summary>
        /// <returns>List<JobSekeerLanguagesReturnDTO></returns>
        public async Task<List<JobSekeerLanguagesReturnDTO>> GetAllJobSekeerLanguagess()
        {
            #region Declare a return type with initial value.
            List<JobSekeerLanguagesReturnDTO> allJobSekeerLanguagess = null;
            #endregion
            try
            {
                allJobSekeerLanguagess = await JobSekeerLanguagesBusinessMapping.GetAllJobSekeerLanguagess();
            }
            catch (Exception exception)  {}
            return allJobSekeerLanguagess;
        }
        /// <summary>
        /// Add JobSekeerLanguages AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSekeerLanguages(JobSekeerLanguagesAddDTO jobSekeerLanguagesAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSekeerLanguagesAddDTO != null)
                {
                    isCreated = await JobSekeerLanguagesBusinessMapping.AddJobSekeerLanguages(jobSekeerLanguagesAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSekeerLanguages By Id 
        /// </summary>
        /// <returns>JobSekeerLanguagesReturnDTO<JobSekeerLanguagesReturnDTO></returns>
        public async Task<JobSekeerLanguagesReturnDTO> GetJobSekeerLanguagesById(int JobSekeerLanguagesId)
        {
            #region Declare a return type with initial value.
            JobSekeerLanguagesReturnDTO JobSekeerLanguages = null;
            #endregion
            try
            {
                if (JobSekeerLanguagesId > default(int))
                {
                    JobSekeerLanguages = await JobSekeerLanguagesBusinessMapping.GetJobSekeerLanguagesById(JobSekeerLanguagesId);
                }
            }
            catch (Exception exception)  {}
            return JobSekeerLanguages;
        }
        /// <summary>
        /// Updae JobSekeerLanguages AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO jobSekeerLanguagesUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSekeerLanguagesUpdateDTO != null)
                {
                    isUpdated = await JobSekeerLanguagesBusinessMapping.UpdateJobSekeerLanguages(jobSekeerLanguagesUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSekeerLanguages AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSekeerLanguages(int JobSekeerLanguagesId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSekeerLanguagesId > default(int))
                {
                    isDeleted = await JobSekeerLanguagesBusinessMapping.DeleteJobSekeerLanguages(JobSekeerLanguagesId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




