using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerGradeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerGradeMapping : IDisposable, IJobSeekerGradeMapping
    {
        public List<JobSeekerGradeReturnDTO> MappingJobSeekerGradeToJobSeekerGradeReturnDTO(List<JobSeekerGrade> JobSeekerGradeList)
        {

            List<JobSeekerGradeReturnDTO> JobSeekerGradeReturnDTOList = null;
            try
            {
                if (JobSeekerGradeList.Any() && JobSeekerGradeList != null)
                {
                    JobSeekerGradeReturnDTOList = JobSeekerGradeList.Select(u => new JobSeekerGradeReturnDTO
                    {
                        JobSeekerGradeId = u.JobSeekerGradeId,
                        JobSeekerGradeName  = u.JobSeekerGradeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerGradeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerGrade></returns>
        public JobSeekerGrade MappingJobSeekerGradeAddDTOToJobSeekerGrade(JobSeekerGradeAddDTO JobSeekerGradeAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerGrade JobSeekerGrade = null;
                #endregion
                try
                {
                    JobSeekerGrade = new JobSeekerGrade
                    {
                        JobSeekerGradeName = JobSeekerGradeAddDTO.JobSeekerGradeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerGrade;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerGrade MappingJobSeekerGradeupdateDTOToJobSeekerGrade(JobSeekerGrade jobSeekerGrade, JobSeekerGradeUpdateDTO JobSeekerGradeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerGrade JobSeekerGrade = jobSeekerGrade;
                #endregion
                try
                {
                    if (JobSeekerGradeUpdateDTO.JobSeekerGradeId > default(int))
                    {
                        JobSeekerGrade.JobSeekerGradeId = JobSeekerGradeUpdateDTO.JobSeekerGradeId;
                        JobSeekerGrade.JobSeekerGradeName = JobSeekerGradeUpdateDTO.JobSeekerGradeName;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerGrade;
            }
            public JobSeekerGradeReturnDTO MappingJobSeekerGradeToJobSeekerGradeReturnDTO(JobSeekerGrade JobSeekerGrade)
            {
                #region Declare a return type with initial value.
                JobSeekerGradeReturnDTO JobSeekerGradeReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerGrade != null)
                    {
                        JobSeekerGradeReturnDTO = new JobSeekerGradeReturnDTO
                        {
                            JobSeekerGradeId = JobSeekerGrade.JobSeekerGradeId,
                            JobSeekerGradeName = JobSeekerGrade.JobSeekerGradeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerGradeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




