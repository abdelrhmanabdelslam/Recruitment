using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerSkillsDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerSkillsMapping : IDisposable, IJobSeekerSkillsMapping
    {
        public List<JobSeekerSkillsReturnDTO> MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(List<JobSeekerSkills> JobSeekerSkillsList)
        {

            List<JobSeekerSkillsReturnDTO> JobSeekerSkillsReturnDTOList = null;
            try
            {
                if (JobSeekerSkillsList.Any() && JobSeekerSkillsList != null)
                {
                    JobSeekerSkillsReturnDTOList = JobSeekerSkillsList.Select(u => new JobSeekerSkillsReturnDTO
                    {
                        JobSeekerId =  u.JobSeekerId,
                        JobSeekerSkillsId = u.JobSeekerSkillsId,
                        Skilles = u.Skilles
                       
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerSkillsReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerSkills></returns>
        public JobSeekerSkills MappingJobSeekerSkillsAddDTOToJobSeekerSkills(JobSeekerSkillsAddDTO JobSeekerSkillsAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerSkills JobSeekerSkills = null;
                #endregion
                try
                {
                    JobSeekerSkills = new JobSeekerSkills
                    {
                        JobSeekerId = JobSeekerSkillsAddDTO.JobSeekerId,
                        Skilles = JobSeekerSkillsAddDTO.Skilles,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerSkills;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerSkills MappingJobSeekerSkillsupdateDTOToJobSeekerSkills(JobSeekerSkills jobSeekerSkills, JobSeekerSkillsUpdateDTO JobSeekerSkillsUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerSkills JobSeekerSkills = jobSeekerSkills;
                #endregion
                try
                {
                    if (JobSeekerSkillsUpdateDTO.JobSeekerSkillsId > default(int))
                    {
                        JobSeekerSkills.JobSeekerId = JobSeekerSkillsUpdateDTO.JobSeekerId;
                        JobSeekerSkills.JobSeekerSkillsId = JobSeekerSkillsUpdateDTO.JobSeekerSkillsId;
                        JobSeekerSkills.Skilles = JobSeekerSkillsUpdateDTO.Skilles;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerSkills;
            }
            public JobSeekerSkillsReturnDTO MappingJobSeekerSkillsToJobSeekerSkillsReturnDTO(JobSeekerSkills JobSeekerSkills)
            {
                #region Declare a return type with initial value.
                JobSeekerSkillsReturnDTO JobSeekerSkillsReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerSkills != null)
                    {
                        JobSeekerSkillsReturnDTO = new JobSeekerSkillsReturnDTO
                        {
                            JobSeekerId = JobSeekerSkills.JobSeekerId,
                            JobSeekerSkillsId = JobSeekerSkills.JobSeekerSkillsId,
                            Skilles = JobSeekerSkills.Skilles
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerSkillsReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




