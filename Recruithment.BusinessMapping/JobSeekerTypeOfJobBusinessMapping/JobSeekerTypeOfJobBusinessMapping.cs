using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerTypeOfJobBusinessMapping : BaseBusinessMapping, IJobSeekerTypeOfJobBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerTypeOfJobMapping JobSeekerTypeOfJobMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerTypeOfJobBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerTypeOfJobMapping jobSeekerTypeOfJobMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerTypeOfJobMapping = jobSeekerTypeOfJobMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerTypeOfJobReturnDTO></returns>
        public async Task<List<JobSeekerTypeOfJobReturnDTO>> GetAllJobSeekerTypeOfJobs()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerTypeOfJobReturnDTO> allJobSeekerTypeOfJobs = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerTypeOfJob> JobSeekerTypeOfJobList = null;
                #endregion
                JobSeekerTypeOfJobList = await UnitOfWork.JobSeekerTypeOfJobRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerTypeOfJobList != null && JobSeekerTypeOfJobList.Any())
                {
                    allJobSeekerTypeOfJobs = JobSeekerTypeOfJobMapping.MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(JobSeekerTypeOfJobList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerTypeOfJobs;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO JobSeekerTypeOfJobAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerTypeOfJobCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerTypeOfJob JobSeekerTypeOfJob = null;
                    #endregion
                    JobSeekerTypeOfJob = JobSeekerTypeOfJobMapping.MappingJobSeekerTypeOfJobAddDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO);
                    if (JobSeekerTypeOfJob != null)
                    {
                        await UnitOfWork.JobSeekerTypeOfJobRepository.Insert(JobSeekerTypeOfJob);
                        isJobSeekerTypeOfJobCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerTypeOfJobCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerTypeOfJobReturnDTO></returns>
            public async Task<JobSeekerTypeOfJobReturnDTO> GetJobSeekerTypeOfJobById(int JobSeekerTypeOfJobId)
            {
                #region Declare a return type with initial value.
                JobSeekerTypeOfJobReturnDTO JobSeekerTypeOfJob = new JobSeekerTypeOfJobReturnDTO();
                #endregion
                try
                {
                    JobSeekerTypeOfJob jobSeekerTypeOfJob = await UnitOfWork.JobSeekerTypeOfJobRepository.GetById(JobSeekerTypeOfJobId);
                    if (jobSeekerTypeOfJob != null)
                    {
                        if (jobSeekerTypeOfJob.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerTypeOfJob = JobSeekerTypeOfJobMapping.MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(jobSeekerTypeOfJob);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerTypeOfJob;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerTypeOfJob(JobSeekerTypeOfJobUpdateDTO JobSeekerTypeOfJobUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerTypeOfJobUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerTypeOfJobUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerTypeOfJob JobSeekerTypeOfJob = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerTypeOfJob = await UnitOfWork.JobSeekerTypeOfJobRepository.GetById(JobSeekerTypeOfJobUpdateDTO.JobSeekerTypeOfJobId);
                        #endregion
                        if (JobSeekerTypeOfJob != null)
                        {
                            #region  Mapping
                            JobSeekerTypeOfJob = JobSeekerTypeOfJobMapping.MappingJobSeekerTypeOfJobupdateDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJob ,JobSeekerTypeOfJobUpdateDTO);
                            #endregion
                            if (JobSeekerTypeOfJob != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerTypeOfJobRepository.Update(JobSeekerTypeOfJob);
                                isJobSeekerTypeOfJobUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerTypeOfJobUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerTypeOfJob(int JobSeekerTypeOfJobId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerTypeOfJobDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerTypeOfJobId > default(int))
                    {
                        #region Vars
                        JobSeekerTypeOfJob JobSeekerTypeOfJob = null;
                        #endregion
                        #region Get JobSeekerTypeOfJob by id
                        JobSeekerTypeOfJob = await UnitOfWork.JobSeekerTypeOfJobRepository.GetById(JobSeekerTypeOfJobId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerTypeOfJob != null)
                        {
                            JobSeekerTypeOfJob.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerTypeOfJobRepository.Update(JobSeekerTypeOfJob);
                            isJobSeekerTypeOfJobDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerTypeOfJobDeleted;
            }
#endregion
        }
    }




