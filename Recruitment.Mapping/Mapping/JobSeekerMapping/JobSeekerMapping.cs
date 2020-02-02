using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSeekerMapping : IDisposable, IJobSeekerMapping
    {
        public List<JobSeekerReturnDTO> MappingJobSeekerToJobSeekerReturnDTO(List<JobSeeker> JobSeekerList)
        {

            List<JobSeekerReturnDTO> JobSeekerReturnDTOList = null;
            try
            {
                if (JobSeekerList.Any() && JobSeekerList != null)
                {
                    JobSeekerReturnDTOList = JobSeekerList.Select(u => new JobSeekerReturnDTO
                    {
                        JobSeekerId = u.JobSeekerId,
                        FirstName =  u.FirstName,
                        CityId = u.CityId,
                        Email = u.Email,
                        GradeId = u.GradeId,
                        Birthdate = u.Birthdate,
                        CurrentCareerLevelId = u.CurrentCareerLevelId,
                        CurrentEducationalLevelId = u.CurrentEducationalLevelId,
                        CurrentJobSearchStatusId = u.CurrentJobSearchStatusId,
                        Gender = u.Gender,
                        GraduationYear = u.GraduationYear,
                        HideMySalary = u.HideMySalary,
                        Lastname = u.Lastname,
                        MinimumSalary = u.MinimumSalary,
                        PhoneNumber = u.PhoneNumber,
                        PhoneNumber2 = u.PhoneNumber2,
                        PublicProfile = u.PublicProfile,
                        University = u.University
                      
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSeekerReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSeeker></returns>
        public JobSeeker MappingJobSeekerAddDTOToJobSeeker(JobSeekerAddDTO JobSeekerAddDTO)
            {
                #region Declare a return type with initial value.
                JobSeeker JobSeeker = null;
                #endregion
                try
                {
                    JobSeeker = new JobSeeker
                    {
                        FirstName = JobSeekerAddDTO.FirstName,
                        CityId = JobSeekerAddDTO.CityId,
                        Email = JobSeekerAddDTO.Email,
                        GradeId = JobSeekerAddDTO.GradeId,
                        Birthdate = JobSeekerAddDTO.Birthdate,
                        CurrentCareerLevelId = JobSeekerAddDTO.CurrentCareerLevelId,
                        CurrentEducationalLevelId = JobSeekerAddDTO.CurrentEducationalLevelId,
                        CurrentJobSearchStatusId = JobSeekerAddDTO.CurrentJobSearchStatusId,
                        Gender = JobSeekerAddDTO.Gender,
                        GraduationYear = JobSeekerAddDTO.GraduationYear,
                        HideMySalary = JobSeekerAddDTO.HideMySalary,
                        Lastname = JobSeekerAddDTO.Lastname,
                        MinimumSalary = JobSeekerAddDTO.MinimumSalary,
                        PhoneNumber = JobSeekerAddDTO.PhoneNumber,
                        PhoneNumber2 = JobSeekerAddDTO.PhoneNumber2,
                        PublicProfile = JobSeekerAddDTO.PublicProfile,
                        University = JobSeekerAddDTO.University,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSeeker;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSeeker MappingJobSeekerupdateDTOToJobSeeker(JobSeeker jobSeeker, JobSeekerUpdateDTO JobSeekerUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSeeker JobSeeker = jobSeeker;
                #endregion
                try
                {
                    if (JobSeekerUpdateDTO.JobSeekerId > default(int))
                    {
                       JobSeeker.FirstName = JobSeekerUpdateDTO.FirstName;
                       JobSeeker.CityId = JobSeekerUpdateDTO.CityId;
                       JobSeeker.Email = JobSeekerUpdateDTO.Email;
                       JobSeeker.GradeId = JobSeekerUpdateDTO.GradeId;
                       JobSeeker.Birthdate = JobSeekerUpdateDTO.Birthdate;
                       JobSeeker.CurrentCareerLevelId = JobSeekerUpdateDTO.CurrentCareerLevelId;
                       JobSeeker.CurrentEducationalLevelId = JobSeekerUpdateDTO.CurrentEducationalLevelId;
                       JobSeeker.CurrentJobSearchStatusId = JobSeekerUpdateDTO.CurrentJobSearchStatusId;
                       JobSeeker.Gender = JobSeekerUpdateDTO.Gender;
                       JobSeeker.GraduationYear = JobSeekerUpdateDTO.GraduationYear;
                       JobSeeker.HideMySalary = JobSeekerUpdateDTO.HideMySalary;
                       JobSeeker.Lastname = JobSeekerUpdateDTO.Lastname;
                       JobSeeker.MinimumSalary = JobSeekerUpdateDTO.MinimumSalary;
                       JobSeeker.PhoneNumber = JobSeekerUpdateDTO.PhoneNumber;
                       JobSeeker.PhoneNumber2 = JobSeekerUpdateDTO.PhoneNumber2;
                       JobSeeker.PublicProfile = JobSeekerUpdateDTO.PublicProfile;
                        JobSeeker.University = JobSeekerUpdateDTO.University;
                    }
                }
                catch (Exception exception) { }
                return JobSeeker;
            }
            public JobSeekerReturnDTO MappingJobSeekerToJobSeekerReturnDTO(JobSeeker JobSeeker)
            {
                #region Declare a return type with initial value.
                JobSeekerReturnDTO JobSeekerReturnDTO = null;
                #endregion
                try
                {
                    if (JobSeeker != null)
                    {
                        JobSeekerReturnDTO = new JobSeekerReturnDTO
                        {
                            FirstName = JobSeeker.FirstName,
                            CityId = JobSeeker.CityId,
                            Email = JobSeeker.Email,
                            GradeId = JobSeeker.GradeId,
                            Birthdate = JobSeeker.Birthdate,
                            CurrentCareerLevelId = JobSeeker.CurrentCareerLevelId,
                            CurrentEducationalLevelId = JobSeeker.CurrentEducationalLevelId,
                            CurrentJobSearchStatusId = JobSeeker.CurrentJobSearchStatusId,
                            Gender = JobSeeker.Gender,
                            GraduationYear = JobSeeker.GraduationYear,
                            HideMySalary = JobSeeker.HideMySalary,
                            Lastname = JobSeeker.Lastname,
                            MinimumSalary = JobSeeker.MinimumSalary,
                            PhoneNumber = JobSeeker.PhoneNumber,
                            PhoneNumber2 = JobSeeker.PhoneNumber2,
                            PublicProfile = JobSeeker.PublicProfile,
                            University = JobSeeker.University,
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSeekerReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




