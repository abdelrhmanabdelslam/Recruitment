using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerFieldOfStudyMapping : IDisposable, IJobSeekerFieldOfStudyMapping
    {
        public List<JobSeekerFieldOfStudyReturnDTO> MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(List<JobSeekerFieldOfStudy> JobSeekerFieldOfStudyList)
        {

            List<JobSeekerFieldOfStudyReturnDTO> JobSeekerFieldOfStudyReturnDTOList = null;
            try
            {
                if (JobSeekerFieldOfStudyList.Any() && JobSeekerFieldOfStudyList != null)
                {
                    JobSeekerFieldOfStudyReturnDTOList = JobSeekerFieldOfStudyList.Select(u => new JobSeekerFieldOfStudyReturnDTO
                    {
                        JobSeekerId = u.JobSeekerId,
                        JobSeekerFieldOfStudyId = u.JobSeekerFieldOfStudyId,
                        JobSeekerFieldOfStudyName  = u.JobSeekerFieldOfStudyName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerFieldOfStudyReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerFieldOfStudy></returns>
        public JobSeekerFieldOfStudy MappingJobSeekerFieldOfStudyAddDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO JobSeekerFieldOfStudyAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerFieldOfStudy JobSeekerFieldOfStudy = null;
                #endregion
                try
                {
                    JobSeekerFieldOfStudy = new JobSeekerFieldOfStudy
                    {
                        JobSeekerId = JobSeekerFieldOfStudyAddDTO.JobSeekerId,
                        JobSeekerFieldOfStudyName = JobSeekerFieldOfStudyAddDTO.JobSeekerFieldOfStudyName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerFieldOfStudy;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerFieldOfStudy MappingJobSeekerFieldOfStudyupdateDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudy jobSeekerFieldOfStudy, JobSeekerFieldOfStudyUpdateDTO JobSeekerFieldOfStudyUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerFieldOfStudy JobSeekerFieldOfStudy = jobSeekerFieldOfStudy;
                #endregion
                try
                {
                    if (JobSeekerFieldOfStudyUpdateDTO.JobSeekerFieldOfStudyId > default(int))
                    {

                        JobSeekerFieldOfStudy.JobSeekerFieldOfStudyId = JobSeekerFieldOfStudyUpdateDTO.JobSeekerFieldOfStudyId;
                        JobSeekerFieldOfStudy.JobSeekerId  = JobSeekerFieldOfStudyUpdateDTO.JobSeekerId ;
                        JobSeekerFieldOfStudy.JobSeekerFieldOfStudyName = JobSeekerFieldOfStudyUpdateDTO.JobSeekerFieldOfStudyName;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerFieldOfStudy;
            }
            public JobSeekerFieldOfStudyReturnDTO MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(JobSeekerFieldOfStudy JobSeekerFieldOfStudy)
            {
                #region Declare a return type with initial value.
                JobSeekerFieldOfStudyReturnDTO JobSeekerFieldOfStudyReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerFieldOfStudy != null)
                    {
                        JobSeekerFieldOfStudyReturnDTO = new JobSeekerFieldOfStudyReturnDTO
                        {
                            JobSeekerFieldOfStudyId = JobSeekerFieldOfStudy.JobSeekerFieldOfStudyId,
                            JobSeekerId = JobSeekerFieldOfStudy.JobSeekerId,
                            JobSeekerFieldOfStudyName = JobSeekerFieldOfStudy.JobSeekerFieldOfStudyName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerFieldOfStudyReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




