using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobRoleDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobRoleBusinessMapping : BaseBusinessMapping, IJobRoleBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobRoleMapping JobRoleMapping { get; }
        #endregion

        #region Constructor
        public JobRoleBusinessMapping(IUnitOfWork unitOfWork, IJobRoleMapping jobRoleMapping)
        {
            UnitOfWork = unitOfWork;
            JobRoleMapping = jobRoleMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobRoleReturnDTO></returns>
        public async Task<List<JobRoleReturnDTO>> GetAllJobRoles()
        {
            #region Declare Return Var with Intial Value
            List<JobRoleReturnDTO> allJobRoles = null;
            #endregion
            try
            {
                #region Vars
                List<JobRole> JobRoleList = null;
                #endregion
                JobRoleList = await UnitOfWork.JobRoleRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobRoleList != null && JobRoleList.Any())
                {
                    allJobRoles = JobRoleMapping.MappingJobRoleToJobRoleReturnDTO(JobRoleList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobRoles;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobRole(JobRoleAddDTO JobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobRoleCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobRole JobRole = null;
                    #endregion
                    JobRole = JobRoleMapping.MappingJobRoleAddDTOToJobRole(JobRoleAddDTO);
                    if (JobRole != null)
                    {
                        await UnitOfWork.JobRoleRepository.Insert(JobRole);
                        isJobRoleCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobRoleCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobRoleReturnDTO></returns>
            public async Task<JobRoleReturnDTO> GetJobRoleById(int JobRoleId)
            {
                #region Declare a return type with initial value.
                JobRoleReturnDTO JobRole = new JobRoleReturnDTO();
                #endregion
                try
                {
                    JobRole jobRole = await UnitOfWork.JobRoleRepository.GetById(JobRoleId);
                    if (jobRole != null)
                    {
                        if (jobRole.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobRole = JobRoleMapping.MappingJobRoleToJobRoleReturnDTO(jobRole);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobRole;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobRole(JobRoleUpdateDTO JobRoleUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobRoleUpdated = default(bool);
                #endregion
                try
                {
                    if (JobRoleUpdateDTO != null)
                    {
                        #region Vars
                        JobRole JobRole = null;
                        #endregion
                        #region Get Activity By Id
                        JobRole = await UnitOfWork.JobRoleRepository.GetById(JobRoleUpdateDTO.JobRoleId);
                        #endregion
                        if (JobRole != null)
                        {
                            #region  Mapping
                            JobRole = JobRoleMapping.MappingJobRoleupdateDTOToJobRole(JobRole ,JobRoleUpdateDTO);
                            #endregion
                            if (JobRole != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobRoleRepository.Update(JobRole);
                                isJobRoleUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobRoleUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobRole(int JobRoleId)
            {
                #region Declare a return type with initial value.
                bool isJobRoleDeleted = default(bool);
                #endregion
                try
                {
                    if (JobRoleId > default(int))
                    {
                        #region Vars
                        JobRole JobRole = null;
                        #endregion
                        #region Get JobRole by id
                        JobRole = await UnitOfWork.JobRoleRepository.GetById(JobRoleId);
                        #endregion
                        #region check if object is not null
                        if (JobRole != null)
                        {
                            JobRole.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobRoleRepository.Update(JobRole);
                            isJobRoleDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobRoleDeleted;
            }
#endregion
        }
    }




