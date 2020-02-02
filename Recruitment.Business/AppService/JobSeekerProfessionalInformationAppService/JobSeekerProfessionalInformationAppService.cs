using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class JobSeekerProfessionalInformationAppService : BaseAppService, IJobSeekerProfessionalInformationAppService
    {
        #region Properties
        public IJobSeekerProfessionalInformationBusinessMapping JobSeekerProfessionalInformationBusinessMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerProfessionalInformationAppService(IJobSeekerProfessionalInformationBusinessMapping jobSeekerProfessionalInformationBusinessMapping)
        {
            JobSeekerProfessionalInformationBusinessMapping = jobSeekerProfessionalInformationBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All JobSeekerProfessionalInformation ActionActivity Logs for All JobSeekerProfessionalInformations
        /// </summary>
        /// <returns>List<JobSeekerProfessionalInformationReturnDTO></returns>
        public async Task<List<JobSeekerProfessionalInformationReturnDTO>> GetAllJobSeekerProfessionalInformations()
        {
            #region Declare a return type with initial value.
            List<JobSeekerProfessionalInformationReturnDTO> allJobSeekerProfessionalInformations = null;
            #endregion
            try
            {
                allJobSeekerProfessionalInformations = await JobSeekerProfessionalInformationBusinessMapping.GetAllJobSeekerProfessionalInformations();
            }
            catch (Exception exception)  {}
            return allJobSeekerProfessionalInformations;
        }
        /// <summary>
        /// Add JobSeekerProfessionalInformation AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO jobSeekerProfessionalInformationAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (jobSeekerProfessionalInformationAddDTO != null)
                {
                    isCreated = await JobSeekerProfessionalInformationBusinessMapping.AddJobSeekerProfessionalInformation(jobSeekerProfessionalInformationAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  JobSeekerProfessionalInformation By Id 
        /// </summary>
        /// <returns>JobSeekerProfessionalInformationReturnDTO<JobSeekerProfessionalInformationReturnDTO></returns>
        public async Task<JobSeekerProfessionalInformationReturnDTO> GetJobSeekerProfessionalInformationById(int JobSeekerProfessionalInformationId)
        {
            #region Declare a return type with initial value.
            JobSeekerProfessionalInformationReturnDTO JobSeekerProfessionalInformation = null;
            #endregion
            try
            {
                if (JobSeekerProfessionalInformationId > default(int))
                {
                    JobSeekerProfessionalInformation = await JobSeekerProfessionalInformationBusinessMapping.GetJobSeekerProfessionalInformationById(JobSeekerProfessionalInformationId);
                }
            }
            catch (Exception exception)  {}
            return JobSeekerProfessionalInformation;
        }
        /// <summary>
        /// Updae JobSeekerProfessionalInformation AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO jobSeekerProfessionalInformationUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (jobSeekerProfessionalInformationUpdateDTO != null)
                {
                    isUpdated = await JobSeekerProfessionalInformationBusinessMapping.UpdateJobSeekerProfessionalInformation(jobSeekerProfessionalInformationUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete JobSeekerProfessionalInformation AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteJobSeekerProfessionalInformation(int JobSeekerProfessionalInformationId)
        {
            bool isDeleted = false;
            try
            {
                if (JobSeekerProfessionalInformationId > default(int))
                {
                    isDeleted = await JobSeekerProfessionalInformationBusinessMapping.DeleteJobSeekerProfessionalInformation(JobSeekerProfessionalInformationId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




