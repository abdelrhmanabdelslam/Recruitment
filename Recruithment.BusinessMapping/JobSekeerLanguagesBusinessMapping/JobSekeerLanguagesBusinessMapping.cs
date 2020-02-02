using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSekeerLanguagesBusinessMapping : BaseBusinessMapping, IJobSekeerLanguagesBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSekeerLanguagesMapping JobSekeerLanguagesMapping { get; }
        #endregion

        #region Constructor
        public JobSekeerLanguagesBusinessMapping(IUnitOfWork unitOfWork, IJobSekeerLanguagesMapping jobSekeerLanguagesMapping)
        {
            UnitOfWork = unitOfWork;
            JobSekeerLanguagesMapping = jobSekeerLanguagesMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSekeerLanguagesReturnDTO></returns>
        public async Task<List<JobSekeerLanguagesReturnDTO>> GetAllJobSekeerLanguagess()
        {
            #region Declare Return Var with Intial Value
            List<JobSekeerLanguagesReturnDTO> allJobSekeerLanguagess = null;
            #endregion
            try
            {
                #region Vars
                List<JobSekeerLanguages> JobSekeerLanguagesList = null;
                #endregion
                JobSekeerLanguagesList = await UnitOfWork.JobSekeerLanguagesRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSekeerLanguagesList != null && JobSekeerLanguagesList.Any())
                {
                    allJobSekeerLanguagess = JobSekeerLanguagesMapping.MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(JobSekeerLanguagesList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSekeerLanguagess;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSekeerLanguages(JobSekeerLanguagesAddDTO JobSekeerLanguagesAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSekeerLanguagesCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSekeerLanguages JobSekeerLanguages = null;
                    #endregion
                    JobSekeerLanguages = JobSekeerLanguagesMapping.MappingJobSekeerLanguagesAddDTOToJobSekeerLanguages(JobSekeerLanguagesAddDTO);
                    if (JobSekeerLanguages != null)
                    {
                        await UnitOfWork.JobSekeerLanguagesRepository.Insert(JobSekeerLanguages);
                        isJobSekeerLanguagesCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSekeerLanguagesCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSekeerLanguagesReturnDTO></returns>
            public async Task<JobSekeerLanguagesReturnDTO> GetJobSekeerLanguagesById(int JobSekeerLanguagesId)
            {
                #region Declare a return type with initial value.
                JobSekeerLanguagesReturnDTO JobSekeerLanguages = new JobSekeerLanguagesReturnDTO();
                #endregion
                try
                {
                    JobSekeerLanguages jobSekeerLanguages = await UnitOfWork.JobSekeerLanguagesRepository.GetById(JobSekeerLanguagesId);
                    if (jobSekeerLanguages != null)
                    {
                        if (jobSekeerLanguages.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSekeerLanguages = JobSekeerLanguagesMapping.MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(jobSekeerLanguages);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSekeerLanguages;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSekeerLanguages(JobSekeerLanguagesUpdateDTO JobSekeerLanguagesUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSekeerLanguagesUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSekeerLanguagesUpdateDTO != null)
                    {
                        #region Vars
                        JobSekeerLanguages JobSekeerLanguages = null;
                        #endregion
                        #region Get Activity By Id
                        JobSekeerLanguages = await UnitOfWork.JobSekeerLanguagesRepository.GetById(JobSekeerLanguagesUpdateDTO.JobSeekerLanguagesId);
                        #endregion
                        if (JobSekeerLanguages != null)
                        {
                            #region  Mapping
                            JobSekeerLanguages = JobSekeerLanguagesMapping.MappingJobSekeerLanguagesupdateDTOToJobSekeerLanguages(JobSekeerLanguages ,JobSekeerLanguagesUpdateDTO);
                            #endregion
                            if (JobSekeerLanguages != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSekeerLanguagesRepository.Update(JobSekeerLanguages);
                                isJobSekeerLanguagesUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSekeerLanguagesUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSekeerLanguages(int JobSekeerLanguagesId)
            {
                #region Declare a return type with initial value.
                bool isJobSekeerLanguagesDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSekeerLanguagesId > default(int))
                    {
                        #region Vars
                        JobSekeerLanguages JobSekeerLanguages = null;
                        #endregion
                        #region Get JobSekeerLanguages by id
                        JobSekeerLanguages = await UnitOfWork.JobSekeerLanguagesRepository.GetById(JobSekeerLanguagesId);
                        #endregion
                        #region check if object is not null
                        if (JobSekeerLanguages != null)
                        {
                            JobSekeerLanguages.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSekeerLanguagesRepository.Update(JobSekeerLanguages);
                            isJobSekeerLanguagesDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSekeerLanguagesDeleted;
            }
#endregion
        }
    }




