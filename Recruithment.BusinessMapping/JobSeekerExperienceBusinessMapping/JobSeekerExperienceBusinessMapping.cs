using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerExperienceDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerExperienceBusinessMapping : BaseBusinessMapping, IJobSeekerExperienceBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerExperienceMapping JobSeekerExperienceMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerExperienceBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerExperienceMapping jobSeekerExperienceMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerExperienceMapping = jobSeekerExperienceMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerExperienceReturnDTO></returns>
        public async Task<List<JobSeekerExperienceReturnDTO>> GetAllJobSeekerExperiences()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerExperienceReturnDTO> allJobSeekerExperiences = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerExperience> JobSeekerExperienceList = null;
                #endregion
                JobSeekerExperienceList = await UnitOfWork.JobSeekerExperienceRepository.GetWhere().ToListAsync();
                if (JobSeekerExperienceList != null && JobSeekerExperienceList.Any())
                {
                    allJobSeekerExperiences = JobSeekerExperienceMapping.MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(JobSeekerExperienceList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerExperiences;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerExperience(JobSeekerExperienceAddDTO JobSeekerExperienceAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerExperienceCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerExperience JobSeekerExperience = null;
                    #endregion
                    JobSeekerExperience = JobSeekerExperienceMapping.MappingJobSeekerExperienceAddDTOToJobSeekerExperience(JobSeekerExperienceAddDTO);
                    if (JobSeekerExperience != null)
                    {
                        await UnitOfWork.JobSeekerExperienceRepository.Insert(JobSeekerExperience);
                        isJobSeekerExperienceCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerExperienceCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerExperienceReturnDTO></returns>
            public async Task<JobSeekerExperienceReturnDTO> GetJobSeekerExperienceById(int JobSeekerExperienceId)
            {
                #region Declare a return type with initial value.
                JobSeekerExperienceReturnDTO JobSeekerExperience = new JobSeekerExperienceReturnDTO();
                #endregion
                try
                {
                    JobSeekerExperience jobSeekerExperience = await UnitOfWork.JobSeekerExperienceRepository.GetById(JobSeekerExperienceId);
                    if (jobSeekerExperience != null)
                    {
                      
                            JobSeekerExperience = JobSeekerExperienceMapping.MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(jobSeekerExperience);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerExperience;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerExperience(JobSeekerExperienceUpdateDTO JobSeekerExperienceUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerExperienceUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerExperienceUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerExperience JobSeekerExperience = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerExperience = await UnitOfWork.JobSeekerExperienceRepository.GetById(JobSeekerExperienceUpdateDTO.JobSeekerExperienceId);
                        #endregion
                        if (JobSeekerExperience != null)
                        {
                            #region  Mapping
                            JobSeekerExperience = JobSeekerExperienceMapping.MappingJobSeekerExperienceupdateDTOToJobSeekerExperience(JobSeekerExperience ,JobSeekerExperienceUpdateDTO);
                            #endregion
                            if (JobSeekerExperience != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerExperienceRepository.Update(JobSeekerExperience);
                                isJobSeekerExperienceUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerExperienceUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerExperience(int JobSeekerExperienceId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerExperienceDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerExperienceId > default(int))
                    {
                        #region Vars
                        JobSeekerExperience JobSeekerExperience = null;
                        #endregion
                        #region Get JobSeekerExperience by id
                        JobSeekerExperience = await UnitOfWork.JobSeekerExperienceRepository.GetById(JobSeekerExperienceId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerExperience != null)
                        {
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerExperienceRepository.Update(JobSeekerExperience);
                            isJobSeekerExperienceDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerExperienceDeleted;
            }
#endregion
        }
    }




