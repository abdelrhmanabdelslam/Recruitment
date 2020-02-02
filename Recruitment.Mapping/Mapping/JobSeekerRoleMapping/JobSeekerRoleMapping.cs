using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerRoleDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerRoleMapping : IDisposable, IJobSeekerRoleMapping
    {
        public List<JobSeekerRoleReturnDTO> MappingJobSeekerRoleToJobSeekerRoleReturnDTO(List<JobSeekerRole> JobSeekerRoleList)
        {

            List<JobSeekerRoleReturnDTO> JobSeekerRoleReturnDTOList = null;
            try
            {
                if (JobSeekerRoleList.Any() && JobSeekerRoleList != null)
                {
                    JobSeekerRoleReturnDTOList = JobSeekerRoleList.Select(u => new JobSeekerRoleReturnDTO
                    {
                        JobSeekerId =  u.JobSeekerId,
                        JobRoleId = u.JobRoleId,
                        JobSeekerRoleId = u.JobSeekerRoleId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerRoleReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerRole></returns>
        public JobSeekerRole MappingJobSeekerRoleAddDTOToJobSeekerRole(JobSeekerRoleAddDTO JobSeekerRoleAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerRole JobSeekerRole = null;
                #endregion
                try
                {
                    JobSeekerRole = new JobSeekerRole
                    {
                        JobSeekerId = JobSeekerRoleAddDTO.JobSeekerId,
                        JobRoleId = JobSeekerRoleAddDTO.JobRoleId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerRole;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerRole MappingJobSeekerRoleupdateDTOToJobSeekerRole(JobSeekerRole jobSeekerRole, JobSeekerRoleUpdateDTO JobSeekerRoleUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerRole JobSeekerRole = jobSeekerRole;
                #endregion
                try
                {
                    if (JobSeekerRoleUpdateDTO.JobSeekerRoleId > default(int))
                    {
                        JobSeekerRole.JobSeekerId = JobSeekerRoleUpdateDTO.JobSeekerId;
                        JobSeekerRole.JobRoleId = JobSeekerRoleUpdateDTO.JobRoleId;
                        JobSeekerRole.JobSeekerRoleId = JobSeekerRoleUpdateDTO.JobSeekerRoleId;
                    
                    }
                }
                catch (Exception exception) { }
                return JobSeekerRole;
            }
            public JobSeekerRoleReturnDTO MappingJobSeekerRoleToJobSeekerRoleReturnDTO(JobSeekerRole JobSeekerRole)
            {
                #region Declare a return type with initial value.
                JobSeekerRoleReturnDTO JobSeekerRoleReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerRole != null)
                    {
                        JobSeekerRoleReturnDTO = new JobSeekerRoleReturnDTO
                        {
                            JobSeekerId = JobSeekerRole.JobSeekerId,
                            JobRoleId = JobSeekerRole.JobRoleId,
                            JobSeekerRoleId = JobSeekerRole.JobSeekerRoleId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerRoleReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




