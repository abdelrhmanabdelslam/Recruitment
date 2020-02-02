using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerApplyDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerApplyMapping : IDisposable, IJobSeekerApplyMapping
    {
        public List<JobSeekerApplyReturnDTO> MappingJobSeekerApplyToJobSeekerApplyReturnDTO(List<JobSeekerApply> JobSeekerApplyList)
        {

            List<JobSeekerApplyReturnDTO> JobSeekerApplyReturnDTOList = null;
            try
            {
                if (JobSeekerApplyList.Any() && JobSeekerApplyList != null)
                {
                    JobSeekerApplyReturnDTOList = JobSeekerApplyList.Select(u => new JobSeekerApplyReturnDTO
                    {
                        JobSeekerId =  u.JobSeekerId,
                        ApplyDate =  u.ApplyDate,
                        JobSeekerApplyId = u.JobSeekerApplyId ,
                        JobSeekerApplyStatusId = u.JobSeekerApplyStatusId,
                        PostId = u.PostId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerApplyReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerApply></returns>
        public JobSeekerApply MappingJobSeekerApplyAddDTOToJobSeekerApply(JobSeekerApplyAddDTO JobSeekerApplyAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerApply JobSeekerApply = null;
                #endregion
                try
                {
                    JobSeekerApply = new JobSeekerApply
                    {

                        JobSeekerId = JobSeekerApplyAddDTO.JobSeekerId,
                        ApplyDate = DateTime.Now,
                        JobSeekerApplyStatusId = JobSeekerApplyAddDTO.JobSeekerApplyStatusId,
                        PostId = JobSeekerApplyAddDTO.PostId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerApply;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerApply MappingJobSeekerApplyupdateDTOToJobSeekerApply(JobSeekerApply jobSeekerApply, JobSeekerApplyUpdateDTO JobSeekerApplyUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerApply JobSeekerApply = jobSeekerApply;
                #endregion
                try
                {
                    if (JobSeekerApplyUpdateDTO.JobSeekerApplyId > default(int))
                    {
                        JobSeekerApply.JobSeekerId = JobSeekerApplyUpdateDTO.JobSeekerId;
                        JobSeekerApply.ApplyDate = JobSeekerApplyUpdateDTO.ApplyDate;
                        JobSeekerApply.JobSeekerApplyId = JobSeekerApplyUpdateDTO.JobSeekerApplyId;
                        JobSeekerApply.JobSeekerApplyStatusId = JobSeekerApplyUpdateDTO.JobSeekerApplyStatusId;
                        JobSeekerApply.PostId = JobSeekerApplyUpdateDTO.PostId;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerApply;
            }
            public JobSeekerApplyReturnDTO MappingJobSeekerApplyToJobSeekerApplyReturnDTO(JobSeekerApply JobSeekerApply)
            {
                #region Declare a return type with initial value.
                JobSeekerApplyReturnDTO JobSeekerApplyReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerApply != null)
                    {
                        JobSeekerApplyReturnDTO = new JobSeekerApplyReturnDTO
                        {
                            JobSeekerId = JobSeekerApply.JobSeekerId,
                            ApplyDate = JobSeekerApply.ApplyDate,
                            JobSeekerApplyId = JobSeekerApply.JobSeekerApplyId,
                            JobSeekerApplyStatusId = JobSeekerApply.JobSeekerApplyStatusId,
                            PostId = JobSeekerApply.PostId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerApplyReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




