using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerRoleDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerRoleBusinessMapping : BaseBusinessMapping, IJobSeekerRoleBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerRoleMapping JobSeekerRoleMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerRoleBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerRoleMapping jobSeekerRoleMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerRoleMapping = jobSeekerRoleMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerRoleReturnDTO></returns>
        public async Task<List<JobSeekerRoleReturnDTO>> GetAllJobSeekerRoles()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerRoleReturnDTO> allJobSeekerRoles = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerRole> JobSeekerRoleList = null;
                #endregion
                JobSeekerRoleList = await UnitOfWork.JobSeekerRoleRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerRoleList != null && JobSeekerRoleList.Any())
                {
                    allJobSeekerRoles = JobSeekerRoleMapping.MappingJobSeekerRoleToJobSeekerRoleReturnDTO(JobSeekerRoleList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerRoles;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerRole(JobSeekerRoleAddDTO JobSeekerRoleAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerRoleCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerRole JobSeekerRole = null;
                    #endregion
                    JobSeekerRole = JobSeekerRoleMapping.MappingJobSeekerRoleAddDTOToJobSeekerRole(JobSeekerRoleAddDTO);
                    if (JobSeekerRole != null)
                    {
                        await UnitOfWork.JobSeekerRoleRepository.Insert(JobSeekerRole);
                        isJobSeekerRoleCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerRoleCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerRoleReturnDTO></returns>
            public async Task<JobSeekerRoleReturnDTO> GetJobSeekerRoleById(int JobSeekerRoleId)
            {
                #region Declare a return type with initial value.
                JobSeekerRoleReturnDTO JobSeekerRole = new JobSeekerRoleReturnDTO();
                #endregion
                try
                {
                    JobSeekerRole jobSeekerRole = await UnitOfWork.JobSeekerRoleRepository.GetById(JobSeekerRoleId);
                    if (jobSeekerRole != null)
                    {
                        if (jobSeekerRole.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerRole = JobSeekerRoleMapping.MappingJobSeekerRoleToJobSeekerRoleReturnDTO(jobSeekerRole);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerRole;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerRole(JobSeekerRoleUpdateDTO JobSeekerRoleUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerRoleUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerRoleUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerRole JobSeekerRole = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerRole = await UnitOfWork.JobSeekerRoleRepository.GetById(JobSeekerRoleUpdateDTO.JobSeekerRoleId);
                        #endregion
                        if (JobSeekerRole != null)
                        {
                            #region  Mapping
                            JobSeekerRole = JobSeekerRoleMapping.MappingJobSeekerRoleupdateDTOToJobSeekerRole(JobSeekerRole ,JobSeekerRoleUpdateDTO);
                            #endregion
                            if (JobSeekerRole != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerRoleRepository.Update(JobSeekerRole);
                                isJobSeekerRoleUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerRoleUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerRole(int JobSeekerRoleId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerRoleDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerRoleId > default(int))
                    {
                        #region Vars
                        JobSeekerRole JobSeekerRole = null;
                        #endregion
                        #region Get JobSeekerRole by id
                        JobSeekerRole = await UnitOfWork.JobSeekerRoleRepository.GetById(JobSeekerRoleId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerRole != null)
                        {
                            JobSeekerRole.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerRoleRepository.Update(JobSeekerRole);
                            isJobSeekerRoleDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerRoleDeleted;
            }
#endregion
        }
    }




