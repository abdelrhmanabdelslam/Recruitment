using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerSkillsDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerSkillsBusinessMapping : BaseBusinessMapping, IJobSeekerSkillsBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerSkillsMapping JobSeekerSkillsMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerSkillsBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerSkillsMapping jobSeekerSkillsMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerSkillsMapping = jobSeekerSkillsMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerSkillsReturnDTO></returns>
        public async Task<List<JobSeekerSkillsReturnDTO>> GetAllJobSeekerSkillss()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerSkillsReturnDTO> allJobSeekerSkillss = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerSkills> JobSeekerSkillsList = null;
                #endregion
                JobSeekerSkillsList = await UnitOfWork.JobSeekerSkillsRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerSkillsList != null && JobSeekerSkillsList.Any())
                {
                    allJobSeekerSkillss = JobSeekerSkillsMapping.MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(JobSeekerSkillsList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerSkillss;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerSkills(JobSeekerSkillsAddDTO JobSeekerSkillsAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerSkillsCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerSkills JobSeekerSkills = null;
                    #endregion
                    JobSeekerSkills = JobSeekerSkillsMapping.MappingJobSeekerSkillsAddDTOToJobSeekerSkills(JobSeekerSkillsAddDTO);
                    if (JobSeekerSkills != null)
                    {
                        await UnitOfWork.JobSeekerSkillsRepository.Insert(JobSeekerSkills);
                        isJobSeekerSkillsCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerSkillsCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerSkillsReturnDTO></returns>
            public async Task<JobSeekerSkillsReturnDTO> GetJobSeekerSkillsById(int JobSeekerSkillsId)
            {
                #region Declare a return type with initial value.
                JobSeekerSkillsReturnDTO JobSeekerSkills = new JobSeekerSkillsReturnDTO();
                #endregion
                try
                {
                    JobSeekerSkills jobSeekerSkills = await UnitOfWork.JobSeekerSkillsRepository.GetById(JobSeekerSkillsId);
                    if (jobSeekerSkills != null)
                    {
                        if (jobSeekerSkills.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerSkills = JobSeekerSkillsMapping.MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(jobSeekerSkills);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerSkills;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerSkills(JobSeekerSkillsUpdateDTO JobSeekerSkillsUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerSkillsUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerSkillsUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerSkills JobSeekerSkills = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerSkills = await UnitOfWork.JobSeekerSkillsRepository.GetById(JobSeekerSkillsUpdateDTO.JobSeekerSkillsId);
                        #endregion
                        if (JobSeekerSkills != null)
                        {
                            #region  Mapping
                            JobSeekerSkills = JobSeekerSkillsMapping.MappingJobSeekerSkillsupdateDTOToJobSeekerSkills(JobSeekerSkills ,JobSeekerSkillsUpdateDTO);
                            #endregion
                            if (JobSeekerSkills != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerSkillsRepository.Update(JobSeekerSkills);
                                isJobSeekerSkillsUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerSkillsUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerSkills(int JobSeekerSkillsId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerSkillsDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerSkillsId > default(int))
                    {
                        #region Vars
                        JobSeekerSkills JobSeekerSkills = null;
                        #endregion
                        #region Get JobSeekerSkills by id
                        JobSeekerSkills = await UnitOfWork.JobSeekerSkillsRepository.GetById(JobSeekerSkillsId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerSkills != null)
                        {
                            JobSeekerSkills.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerSkillsRepository.Update(JobSeekerSkills);
                            isJobSeekerSkillsDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerSkillsDeleted;
            }
#endregion
        }
    }




