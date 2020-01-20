using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobRoleDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobRoleMapping : IDisposable, IJobRoleMapping
    {
        public List<JobRoleReturnDTO> MappingJobRoleToJobRoleReturnDTO(List<JobRole> JobRoleList)
        {

            List<JobRoleReturnDTO> JobRoleReturnDTOList = null;
            try
            {
                if (JobRoleList.Any() && JobRoleList != null)
                {
                    JobRoleReturnDTOList = JobRoleList.Select(u => new JobRoleReturnDTO
                    {
                        JobRoleId = (byte)u.JobRoleId,
                        Description = u.Description,
                        JobRoleName = u.JobRoleName
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobRoleReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobRole></returns>
        public JobRole MappingJobRoleAddDTOToJobRole(JobRoleAddDTO JobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                JobRole JobRole = null;
                #endregion
                try
                {
                    JobRole = new JobRole
                    {
                        JobRoleName = JobRoleAddDTO.JobRoleName,
                        Description = JobRoleAddDTO.Description,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobRole;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobRole MappingJobRoleupdateDTOToJobRole(JobRole jobRole, JobRoleUpdateDTO JobRoleUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobRole JobRole = jobRole;
                #endregion
                try
                {
                    if (JobRoleUpdateDTO.JobRoleId > default(int))
                    {
                        JobRole.JobRoleName = JobRoleUpdateDTO.JobRoleName;
                        JobRole.JobRoleId = JobRoleUpdateDTO.JobRoleId;
                        JobRole.Description = JobRoleUpdateDTO.Description;
                    }
                }
                catch (Exception exception) { }
                return JobRole;
            }
            public JobRoleReturnDTO MappingJobRoleToJobRoleReturnDTO(JobRole JobRole)
            {
                #region Declare a return type with initial value.
                JobRoleReturnDTO JobRoleReturnDTO = null;
                #endregion
                try
                {
                    if (JobRole != null)
                    {
                        JobRoleReturnDTO = new JobRoleReturnDTO
                        {
                            JobRoleId =(byte) JobRole.JobRoleId,
                            Description = JobRole.Description,
                             JobRoleName= JobRole.JobRoleName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobRoleReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




