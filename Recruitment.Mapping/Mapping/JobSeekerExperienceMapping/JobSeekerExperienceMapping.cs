using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerExperienceDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerExperienceMapping : IDisposable, IJobSeekerExperienceMapping
    {
        public List<JobSeekerExperienceReturnDTO> MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(List<JobSeekerExperience> JobSeekerExperienceList)
        {

            List<JobSeekerExperienceReturnDTO> JobSeekerExperienceReturnDTOList = null;
            try
            {
                if (JobSeekerExperienceList.Any() && JobSeekerExperienceList != null)
                {
                    JobSeekerExperienceReturnDTOList = JobSeekerExperienceList.Select(u => new JobSeekerExperienceReturnDTO
                    {
                        JobSeekerId = u.JobSeekerId,
                        CompanyName = u.CompanyName,
                        EndFromMonth1 = u.EndFromMonth1,
                        EndToMonth = u.EndToMonth,
                        IsCurrentJob = u.IsCurrentJob,
                        JobSeekerExperienceId = u.JobSeekerExperienceId,
                        JobTitle = u.JobTitle,
                        StartFromMonth = u.StartFromMonth,
                        StartToMonth = u.StartToMonth,
                        TypeOfJobId = u.TypeOfJobId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerExperienceReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerExperience></returns>
        public JobSeekerExperience MappingJobSeekerExperienceAddDTOToJobSeekerExperience(JobSeekerExperienceAddDTO JobSeekerExperienceAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerExperience JobSeekerExperience = null;
                #endregion
                try
                {
                    JobSeekerExperience = new JobSeekerExperience
                    {

                        JobSeekerId = JobSeekerExperienceAddDTO.JobSeekerId,
                        CompanyName = JobSeekerExperienceAddDTO.CompanyName,
                        EndFromMonth1 = JobSeekerExperienceAddDTO.EndFromMonth1,
                        EndToMonth = JobSeekerExperienceAddDTO.EndToMonth,
                        IsCurrentJob = JobSeekerExperienceAddDTO.IsCurrentJob,
                        JobTitle = JobSeekerExperienceAddDTO.JobTitle,
                        StartFromMonth = JobSeekerExperienceAddDTO.StartFromMonth,
                        StartToMonth = JobSeekerExperienceAddDTO.StartToMonth,
                        TypeOfJobId = JobSeekerExperienceAddDTO.TypeOfJobId
                    };
                }
                catch (Exception exception) { }
                return JobSeekerExperience;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerExperience MappingJobSeekerExperienceupdateDTOToJobSeekerExperience(JobSeekerExperience jobSeekerExperience, JobSeekerExperienceUpdateDTO JobSeekerExperienceUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerExperience JobSeekerExperience = jobSeekerExperience;
                #endregion
                try
                {
                    if (JobSeekerExperienceUpdateDTO.JobSeekerExperienceId > default(int))
                    {
                      JobSeekerExperience.JobSeekerId = JobSeekerExperienceUpdateDTO.JobSeekerId;
                      JobSeekerExperience.CompanyName = JobSeekerExperienceUpdateDTO.CompanyName;
                      JobSeekerExperience.EndFromMonth1 = JobSeekerExperienceUpdateDTO.EndFromMonth1;
                      JobSeekerExperience.EndToMonth = JobSeekerExperienceUpdateDTO.EndToMonth;
                      JobSeekerExperience.IsCurrentJob = JobSeekerExperienceUpdateDTO.IsCurrentJob;
                      JobSeekerExperience.JobTitle = JobSeekerExperienceUpdateDTO.JobTitle;
                      JobSeekerExperience.StartFromMonth = JobSeekerExperienceUpdateDTO.StartFromMonth;
                      JobSeekerExperience.StartToMonth = JobSeekerExperienceUpdateDTO.StartToMonth;
                      JobSeekerExperience.TypeOfJobId = JobSeekerExperienceUpdateDTO.TypeOfJobId;

                    }
                }
                catch (Exception exception) { }
                return JobSeekerExperience;
            }
            public JobSeekerExperienceReturnDTO MappingJobSeekerExperienceToJobSeekerExperienceReturnDTO(JobSeekerExperience JobSeekerExperience)
            {
                #region Declare a return type with initial value.
                JobSeekerExperienceReturnDTO JobSeekerExperienceReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerExperience != null)
                    {
                        JobSeekerExperienceReturnDTO = new JobSeekerExperienceReturnDTO
                        {
                            JobSeekerId = JobSeekerExperience.JobSeekerId,
                            CompanyName = JobSeekerExperience.CompanyName,
                            EndFromMonth1 = JobSeekerExperience.EndFromMonth1,
                            EndToMonth = JobSeekerExperience.EndToMonth,
                            IsCurrentJob = JobSeekerExperience.IsCurrentJob,
                            JobTitle = JobSeekerExperience.JobTitle,
                            StartFromMonth = JobSeekerExperience.StartFromMonth,
                            StartToMonth = JobSeekerExperience.StartToMonth,
                            TypeOfJobId = JobSeekerExperience.TypeOfJobId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerExperienceReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




