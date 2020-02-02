using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerApplyDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerApplyBusinessMapping : BaseBusinessMapping, IJobSeekerApplyBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerApplyMapping JobSeekerApplyMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerApplyBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerApplyMapping jobSeekerApplyMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerApplyMapping = jobSeekerApplyMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerApplyReturnDTO></returns>
        public async Task<List<JobSeekerApplyReturnDTO>> GetAllJobSeekerApplys()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerApplyReturnDTO> allJobSeekerApplys = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerApply> JobSeekerApplyList = null;
                #endregion
                JobSeekerApplyList = await UnitOfWork.JobSeekerApplyRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerApplyList != null && JobSeekerApplyList.Any())
                {
                    allJobSeekerApplys = JobSeekerApplyMapping.MappingJobSeekerApplyToJobSeekerApplyReturnDTO(JobSeekerApplyList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerApplys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerApply(JobSeekerApplyAddDTO JobSeekerApplyAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerApply JobSeekerApply = null;
                    #endregion
                    JobSeekerApply = JobSeekerApplyMapping.MappingJobSeekerApplyAddDTOToJobSeekerApply(JobSeekerApplyAddDTO);
                    if (JobSeekerApply != null)
                    {
                        await UnitOfWork.JobSeekerApplyRepository.Insert(JobSeekerApply);
                        isJobSeekerApplyCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerApplyReturnDTO></returns>
            public async Task<JobSeekerApplyReturnDTO> GetJobSeekerApplyById(int JobSeekerApplyId)
            {
                #region Declare a return type with initial value.
                JobSeekerApplyReturnDTO JobSeekerApply = new JobSeekerApplyReturnDTO();
                #endregion
                try
                {
                    JobSeekerApply jobSeekerApply = await UnitOfWork.JobSeekerApplyRepository.GetById(JobSeekerApplyId);
                    if (jobSeekerApply != null)
                    {
                        if (jobSeekerApply.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerApply = JobSeekerApplyMapping.MappingJobSeekerApplyToJobSeekerApplyReturnDTO(jobSeekerApply);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerApply;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerApply(JobSeekerApplyUpdateDTO JobSeekerApplyUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerApplyUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerApply JobSeekerApply = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerApply = await UnitOfWork.JobSeekerApplyRepository.GetById(JobSeekerApplyUpdateDTO.JobSeekerApplyId);
                        #endregion
                        if (JobSeekerApply != null)
                        {
                            #region  Mapping
                            JobSeekerApply = JobSeekerApplyMapping.MappingJobSeekerApplyupdateDTOToJobSeekerApply(JobSeekerApply ,JobSeekerApplyUpdateDTO);
                            #endregion
                            if (JobSeekerApply != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerApplyRepository.Update(JobSeekerApply);
                                isJobSeekerApplyUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerApply(int JobSeekerApplyId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerApplyDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerApplyId > default(int))
                    {
                        #region Vars
                        JobSeekerApply JobSeekerApply = null;
                        #endregion
                        #region Get JobSeekerApply by id
                        JobSeekerApply = await UnitOfWork.JobSeekerApplyRepository.GetById(JobSeekerApplyId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerApply != null)
                        {
                            JobSeekerApply.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerApplyRepository.Update(JobSeekerApply);
                            isJobSeekerApplyDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerApplyDeleted;
            }
#endregion
        }
    }




