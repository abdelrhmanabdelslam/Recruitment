using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerBusinessMapping : BaseBusinessMapping, IJobSeekerBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerMapping JobSeekerMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerMapping jobSeekerMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerMapping = jobSeekerMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerReturnDTO></returns>
        public async Task<List<JobSeekerReturnDTO>> GetAllJobSeekers()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerReturnDTO> allJobSeekers = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeeker> JobSeekerList = null;
                #endregion
                JobSeekerList = await UnitOfWork.JobSeekerRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerList != null && JobSeekerList.Any())
                {
                    allJobSeekers = JobSeekerMapping.MappingJobSeekerToJobSeekerReturnDTO(JobSeekerList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekers;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeeker(JobSeekerAddDTO JobSeekerAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeeker JobSeeker = null;
                    #endregion
                    JobSeeker = JobSeekerMapping.MappingJobSeekerAddDTOToJobSeeker(JobSeekerAddDTO);
                    if (JobSeeker != null)
                    {
                        await UnitOfWork.JobSeekerRepository.Insert(JobSeeker);
                        isJobSeekerCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerReturnDTO></returns>
            public async Task<JobSeekerReturnDTO> GetJobSeekerById(int JobSeekerId)
            {
                #region Declare a return type with initial value.
                JobSeekerReturnDTO JobSeeker = new JobSeekerReturnDTO();
                #endregion
                try
                {
                    JobSeeker jobSeeker = await UnitOfWork.JobSeekerRepository.GetById(JobSeekerId);
                    if (jobSeeker != null)
                    {
                        if (jobSeeker.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeeker = JobSeekerMapping.MappingJobSeekerToJobSeekerReturnDTO(jobSeeker);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeeker;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeeker(JobSeekerUpdateDTO JobSeekerUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerUpdateDTO != null)
                    {
                        #region Vars
                        JobSeeker JobSeeker = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeeker = await UnitOfWork.JobSeekerRepository.GetById(JobSeekerUpdateDTO.JobSeekerId);
                        #endregion
                        if (JobSeeker != null)
                        {
                            #region  Mapping
                            JobSeeker = JobSeekerMapping.MappingJobSeekerupdateDTOToJobSeeker(JobSeeker ,JobSeekerUpdateDTO);
                            #endregion
                            if (JobSeeker != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerRepository.Update(JobSeeker);
                                isJobSeekerUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeeker(int JobSeekerId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerId > default(int))
                    {
                        #region Vars
                        JobSeeker JobSeeker = null;
                        #endregion
                        #region Get JobSeeker by id
                        JobSeeker = await UnitOfWork.JobSeekerRepository.GetById(JobSeekerId);
                        #endregion
                        #region check if object is not null
                        if (JobSeeker != null)
                        {
                            JobSeeker.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerRepository.Update(JobSeeker);
                            isJobSeekerDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerDeleted;
            }
#endregion
        }
    }




