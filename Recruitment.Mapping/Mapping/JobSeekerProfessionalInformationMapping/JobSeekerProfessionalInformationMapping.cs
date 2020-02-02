using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerProfessionalInformationMapping : IDisposable, IJobSeekerProfessionalInformationMapping
    {
        public List<JobSeekerProfessionalInformationReturnDTO> MappingJobSeekerProfessionalInformationToJobSeekerProfessionalInformationReturnDTO(List<JobSeekerProfessionalInformation> JobSeekerProfessionalInformationList)
        {

            List<JobSeekerProfessionalInformationReturnDTO> JobSeekerProfessionalInformationReturnDTOList = null;
            try
            {
                if (JobSeekerProfessionalInformationList.Any() && JobSeekerProfessionalInformationList != null)
                {
                    JobSeekerProfessionalInformationReturnDTOList = JobSeekerProfessionalInformationList.Select(u => new JobSeekerProfessionalInformationReturnDTO
                    {
                        JobSeekerId = u.JobSeekerId,
                        GradeId = u.GradeId,
                        CurrentEducationalLevelId = u.CurrentEducationalLevelId,
                        GraduationYear = u.GraduationYear,
                        JobSeekerProfessionalInformationId = u.JobSeekerProfessionalInformationId,
                        UniversityOrIstitution = u.UniversityOrIstitution,
                        YearsOfExperience = u.YearsOfExperience
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerProfessionalInformationReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeekerProfessionalInformation></returns>
        public JobSeekerProfessionalInformation MappingJobSeekerProfessionalInformationAddDTOToJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO JobSeekerProfessionalInformationAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeekerProfessionalInformation JobSeekerProfessionalInformation = null;
                #endregion
                try
                {
                    JobSeekerProfessionalInformation = new JobSeekerProfessionalInformation
                    {
                        JobSeekerId = JobSeekerProfessionalInformationAddDTO.JobSeekerId,
                        GradeId = JobSeekerProfessionalInformationAddDTO.GradeId,
                        CurrentEducationalLevelId = JobSeekerProfessionalInformationAddDTO.CurrentEducationalLevelId,
                        GraduationYear = JobSeekerProfessionalInformationAddDTO.GraduationYear,
                        UniversityOrIstitution = JobSeekerProfessionalInformationAddDTO.UniversityOrIstitution,
                        YearsOfExperience = JobSeekerProfessionalInformationAddDTO.YearsOfExperience,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeekerProfessionalInformation;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeekerProfessionalInformation MappingJobSeekerProfessionalInformationupdateDTOToJobSeekerProfessionalInformation(JobSeekerProfessionalInformation jobSeekerProfessionalInformation, JobSeekerProfessionalInformationUpdateDTO JobSeekerProfessionalInformationUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeekerProfessionalInformation JobSeekerProfessionalInformation = jobSeekerProfessionalInformation;
                #endregion
                try
                {
                    if (JobSeekerProfessionalInformationUpdateDTO.JobSeekerProfessionalInformationId > default(int))
                    {
                        JobSeekerProfessionalInformation.JobSeekerId =
                            JobSeekerProfessionalInformationUpdateDTO.JobSeekerId;
                        JobSeekerProfessionalInformation.GradeId = JobSeekerProfessionalInformationUpdateDTO.GradeId;
                        JobSeekerProfessionalInformation.CurrentEducationalLevelId =
                            JobSeekerProfessionalInformationUpdateDTO.CurrentEducationalLevelId;
                        JobSeekerProfessionalInformation.GraduationYear =
                            JobSeekerProfessionalInformationUpdateDTO.GraduationYear;
                        JobSeekerProfessionalInformation.UniversityOrIstitution =
                            JobSeekerProfessionalInformationUpdateDTO.UniversityOrIstitution;
                        JobSeekerProfessionalInformation.YearsOfExperience =
                            JobSeekerProfessionalInformationUpdateDTO.YearsOfExperience;
                    }
                }
                catch (Exception exception) { }
                return JobSeekerProfessionalInformation;
            }
            public JobSeekerProfessionalInformationReturnDTO MappingJobSeekerProfessionalInformationToJobSeekerProfessionalInformationReturnDTO(JobSeekerProfessionalInformation JobSeekerProfessionalInformation)
            {
                #region Declare a return type with initial value.
                JobSeekerProfessionalInformationReturnDTO JobSeekerProfessionalInformationReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeekerProfessionalInformation != null)
                    {
                        JobSeekerProfessionalInformationReturnDTO = new JobSeekerProfessionalInformationReturnDTO
                        {

                            JobSeekerId = JobSeekerProfessionalInformation.JobSeekerId,
                            GradeId = JobSeekerProfessionalInformation.GradeId,
                            CurrentEducationalLevelId = JobSeekerProfessionalInformation.CurrentEducationalLevelId,
                            GraduationYear = JobSeekerProfessionalInformation.GraduationYear,
                            JobSeekerProfessionalInformationId = JobSeekerProfessionalInformation.JobSeekerProfessionalInformationId,
                            UniversityOrIstitution = JobSeekerProfessionalInformation.UniversityOrIstitution,
                            YearsOfExperience = JobSeekerProfessionalInformation.YearsOfExperience
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerProfessionalInformationReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




