using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerApplyStatusDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerApplyStatusMapping : IDisposable, IJobSeekerApplyStatusMapping
    {
        public List<JobSeekerApplyStatusReturnDTO> MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(List<JobSeekerApplyStatus> JobSeekerApplyStatusList)
        {

            List<JobSeekerApplyStatusReturnDTO> JobSeekerApplyStatusReturnDTOList = null;
            try
            {
                if (JobSeekerApplyStatusList.Any() && JobSeekerApplyStatusList != null)
                {
                    JobSeekerApplyStatusReturnDTOList = JobSeekerApplyStatusList.Select(u => new JobSeekerApplyStatusReturnDTO
                    {
                        JobSeekerApplyStatusId = u.JobSeekerApplyStatusId,
                        JobSeekerApplyStatusName  = u.JobSeekerApplyStatusName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerApplyStatusReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerApplyStatus></returns>
        public JobSeekerApplyStatus MappingJobSeekerApplyStatusAddDTOToJobSeekerApplyStatus(JobSeekerApplyStatusAddDTO JobSeekerApplyStatusAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerApplyStatus JobSeekerApplyStatus = null;
                #endregion
                try
                {
                    JobSeekerApplyStatus = new JobSeekerApplyStatus
                    {
                        JobSeekerApplyStatusName = JobSeekerApplyStatusAddDTO.JobSeekerApplyStatusName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerApplyStatus;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerApplyStatus MappingJobSeekerApplyStatusupdateDTOToJobSeekerApplyStatus(JobSeekerApplyStatus jobSeekerApplyStatus, JobSeekerApplyStatusUpdateDTO JobSeekerApplyStatusUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerApplyStatus JobSeekerApplyStatus = jobSeekerApplyStatus;
                #endregion
                try
                {
                    if (JobSeekerApplyStatusUpdateDTO.JobSeekerApplyStatusId > default(int))
                    {
                        JobSeekerApplyStatus.JobSeekerApplyStatusId = JobSeekerApplyStatusUpdateDTO.JobSeekerApplyStatusId;
                        JobSeekerApplyStatus.JobSeekerApplyStatusName = JobSeekerApplyStatusUpdateDTO.JobSeekerApplyStatusName;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerApplyStatus;
            }
            public JobSeekerApplyStatusReturnDTO MappingJobSeekerApplyStatusToJobSeekerApplyStatusReturnDTO(JobSeekerApplyStatus JobSeekerApplyStatus)
            {
                #region Declare a return type with initial value.
                JobSeekerApplyStatusReturnDTO JobSeekerApplyStatusReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerApplyStatus != null)
                    {
                        JobSeekerApplyStatusReturnDTO = new JobSeekerApplyStatusReturnDTO
                        {
                            JobSeekerApplyStatusId = JobSeekerApplyStatus.JobSeekerApplyStatusId,
                            JobSeekerApplyStatusName = JobSeekerApplyStatus.JobSeekerApplyStatusName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerApplyStatusReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




