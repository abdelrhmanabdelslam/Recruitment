using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerTypeOfJobDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerTypeOfJobMapping : IDisposable, IJobSeekerTypeOfJobMapping
    {
        public List<JobSeekerTypeOfJobReturnDTO> MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(List<JobSeekerTypeOfJob> JobSeekerTypeOfJobList)
        {

            List<JobSeekerTypeOfJobReturnDTO> JobSeekerTypeOfJobReturnDTOList = null;
            try
            {
                if (JobSeekerTypeOfJobList.Any() && JobSeekerTypeOfJobList != null)
                {
                    JobSeekerTypeOfJobReturnDTOList = JobSeekerTypeOfJobList.Select(u => new JobSeekerTypeOfJobReturnDTO
                    {
                        JobSeekerId =  u.JobSeekerId,
                        TypeOfJobId = u.TypeOfJobId,
                        JobSeekerTypeOfJobId =  u.JobSeekerTypeOfJobId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerTypeOfJobReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerTypeOfJob></returns>
        public JobSeekerTypeOfJob MappingJobSeekerTypeOfJobAddDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJobAddDTO JobSeekerTypeOfJobAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerTypeOfJob JobSeekerTypeOfJob = null;
                #endregion
                try
                {
                    JobSeekerTypeOfJob = new JobSeekerTypeOfJob
                    {
                        JobSeekerId = JobSeekerTypeOfJobAddDTO.JobSeekerId,
                        TypeOfJobId = JobSeekerTypeOfJobAddDTO.TypeOfJobId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerTypeOfJob;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerTypeOfJob MappingJobSeekerTypeOfJobupdateDTOToJobSeekerTypeOfJob(JobSeekerTypeOfJob jobSeekerTypeOfJob, JobSeekerTypeOfJobUpdateDTO JobSeekerTypeOfJobUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerTypeOfJob JobSeekerTypeOfJob = jobSeekerTypeOfJob;
                #endregion
                try
                {
                    if (JobSeekerTypeOfJobUpdateDTO.JobSeekerTypeOfJobId > default(int))
                    {
                        JobSeekerTypeOfJob.JobSeekerId = JobSeekerTypeOfJobUpdateDTO.JobSeekerId;
                        JobSeekerTypeOfJob.TypeOfJobId = JobSeekerTypeOfJobUpdateDTO.TypeOfJobId;
                        JobSeekerTypeOfJob.JobSeekerTypeOfJobId = JobSeekerTypeOfJobUpdateDTO.JobSeekerTypeOfJobId;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerTypeOfJob;
            }
            public JobSeekerTypeOfJobReturnDTO MappingJobSeekerTypeOfJobToJobSeekerTypeOfJobReturnDTO(JobSeekerTypeOfJob JobSeekerTypeOfJob)
            {
                #region Declare a return type with initial value.
                JobSeekerTypeOfJobReturnDTO JobSeekerTypeOfJobReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerTypeOfJob != null)
                    {
                        JobSeekerTypeOfJobReturnDTO = new JobSeekerTypeOfJobReturnDTO
                        {
                            JobSeekerId = JobSeekerTypeOfJob.JobSeekerId,
                            TypeOfJobId = JobSeekerTypeOfJob.TypeOfJobId,
                            JobSeekerTypeOfJobId = JobSeekerTypeOfJob.JobSeekerTypeOfJobId
                  
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerTypeOfJobReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




