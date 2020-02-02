using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerApplyStatusBusinessMapping : BaseBusinessMapping, IJobSeekerApplyStatusBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerApplyStatusMapping JobSeekerApplyStatusMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerApplyStatusBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerApplyStatusMapping jobSeekerApplyStatusMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerApplyStatusMapping = jobSeekerApplyStatusMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerApplyStatusReturnDTO></returns>
        public async Task<List<JobSeekerApplyStatusReturnDTO>> GetAllJobSeekerApplyStatuss()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerApplyStatusReturnDTO> allJobSeekerApplyStatuss = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerApplyStatus> JobSeekerApplyStatusList = null;
                #endregion
                JobSeekerApplyStatusList = await UnitOfWork.JobSeekerApplyStatusRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerApplyStatusList != null && JobSeekerApplyStatusList.Any())
                {
                    allJobSeekerApplyStatuss = JobSeekerApplyStatusMapping.MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(JobSeekerApplyStatusList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerApplyStatuss;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO JobSeekerApplyStatusAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyStatusCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerApplyStatus JobSeekerApplyStatus = null;
                    #endregion
                    JobSeekerApplyStatus = JobSeekerApplyStatusMapping.MappingJobSeekerApplyStatusAddDTOToJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO);
                    if (JobSeekerApplyStatus != null)
                    {
                        await UnitOfWork.JobSeekerApplyStatusRepository.Insert(JobSeekerApplyStatus);
                        isJobSeekerApplyStatusCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyStatusCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerApplyStatusReturnDTO></returns>
            public async Task<JobSeekerApplyStatusReturnDTO> GetJobSeekerApplyStatusById(int JobSeekerApplyStatusId)
            {
                #region Declare a return type with initial value.
                JobSeekerApplyStatusReturnDTO JobSeekerApplyStatus = new JobSeekerApplyStatusReturnDTO();
                #endregion
                try
                {
                    JobSeekerApplyStatus jobSeekerApplyStatus = await UnitOfWork.JobSeekerApplyStatusRepository.GetById(JobSeekerApplyStatusId);
                    if (jobSeekerApplyStatus != null)
                    {
                        if (jobSeekerApplyStatus.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerApplyStatus = JobSeekerApplyStatusMapping.MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(jobSeekerApplyStatus);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerApplyStatus;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerApplyStatus(JobSeekerApplyStatusUpdateDTO JobSeekerApplyStatusUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyStatusUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerApplyStatusUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerApplyStatus JobSeekerApplyStatus = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerApplyStatus = await UnitOfWork.JobSeekerApplyStatusRepository.GetById(JobSeekerApplyStatusUpdateDTO.JobSeekerApplyStatusId);
                        #endregion
                        if (JobSeekerApplyStatus != null)
                        {
                            #region  Mapping
                            JobSeekerApplyStatus = JobSeekerApplyStatusMapping.MappingJobSeekerApplyStatusupdateDTOToJobSeekerApplyStatus(JobSeekerApplyStatus ,JobSeekerApplyStatusUpdateDTO);
                            #endregion
                            if (JobSeekerApplyStatus != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerApplyStatusRepository.Update(JobSeekerApplyStatus);
                                isJobSeekerApplyStatusUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyStatusUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerApplyStatus(int JobSeekerApplyStatusId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyStatusDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerApplyStatusId > default(int))
                    {
                        #region Vars
                        JobSeekerApplyStatus JobSeekerApplyStatus = null;
                        #endregion
                        #region Get JobSeekerApplyStatus by id
                        JobSeekerApplyStatus = await UnitOfWork.JobSeekerApplyStatusRepository.GetById(JobSeekerApplyStatusId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerApplyStatus != null)
                        {
                            JobSeekerApplyStatus.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerApplyStatusRepository.Update(JobSeekerApplyStatus);
                            isJobSeekerApplyStatusDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyStatusDeleted;
            }
#endregion
        }
    }




