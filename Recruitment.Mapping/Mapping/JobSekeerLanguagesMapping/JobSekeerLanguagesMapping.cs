using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSekeerLanguagesDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class JobSekeerLanguagesMapping : IDisposable, IJobSekeerLanguagesMapping
    {
        public List<JobSekeerLanguagesReturnDTO> MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(List<JobSekeerLanguages> JobSekeerLanguagesList)
        {

            List<JobSekeerLanguagesReturnDTO> JobSekeerLanguagesReturnDTOList = null;
            try
            {
                if (JobSekeerLanguagesList.Any() && JobSekeerLanguagesList != null)
                {
                    JobSekeerLanguagesReturnDTOList = JobSekeerLanguagesList.Select(u => new JobSekeerLanguagesReturnDTO
                    {
                        JobSeekerId =  u.JobSeekerId,
                        JobSeekerLanguagesId = u.JobSeekerLanguagesId,
                        LanguageId = u.LanguageId,
                        LanguageLevelId = u.LanguageLevelId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return JobSekeerLanguagesReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<JobSekeerLanguages></returns>
        public JobSekeerLanguages MappingJobSekeerLanguagesAddDTOToJobSekeerLanguages(JobSekeerLanguagesAddDTO JobSekeerLanguagesAddDTO)
            {
                #region Declare a return type with initial value.
                JobSekeerLanguages JobSekeerLanguages = null;
                #endregion
                try
                {
                    JobSekeerLanguages = new JobSekeerLanguages
                    {

                        JobSeekerId = JobSekeerLanguagesAddDTO.JobSeekerId,
                        LanguageId = JobSekeerLanguagesAddDTO.LanguageId,
                        LanguageLevelId = JobSekeerLanguagesAddDTO.LanguageLevelId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return JobSekeerLanguages;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public JobSekeerLanguages MappingJobSekeerLanguagesupdateDTOToJobSekeerLanguages(JobSekeerLanguages jobSekeerLanguages, JobSekeerLanguagesUpdateDTO JobSekeerLanguagesUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                JobSekeerLanguages JobSekeerLanguages = jobSekeerLanguages;
                #endregion
                try
                {
                    if (JobSekeerLanguagesUpdateDTO.JobSeekerLanguagesId > default(int))
                    {
                        JobSekeerLanguages.JobSeekerId = JobSekeerLanguagesUpdateDTO.JobSeekerId;
                        JobSekeerLanguages.JobSeekerLanguagesId = JobSekeerLanguagesUpdateDTO.JobSeekerLanguagesId;
                        JobSekeerLanguages.LanguageId = JobSekeerLanguagesUpdateDTO.LanguageId;
                        JobSekeerLanguages.LanguageLevelId = JobSekeerLanguagesUpdateDTO.LanguageLevelId;
                    
                    }
                }
                catch (Exception exception) { }
                return JobSekeerLanguages;
            }
            public JobSekeerLanguagesReturnDTO MappingJobSekeerLanguagesToJobSekeerLanguagesReturnDTO(JobSekeerLanguages JobSekeerLanguages)
            {
                #region Declare a return type with initial value.
                JobSekeerLanguagesReturnDTO JobSekeerLanguagesReturnDTO = null;
                #endregion
                try
                {
                    if (JobSekeerLanguages != null)
                    {
                        JobSekeerLanguagesReturnDTO = new JobSekeerLanguagesReturnDTO
                        {

                            JobSeekerId = JobSekeerLanguages.JobSeekerId,
                            JobSeekerLanguagesId = JobSekeerLanguages.JobSeekerLanguagesId,
                            LanguageId = JobSekeerLanguages.LanguageId,
                            LanguageLevelId = JobSekeerLanguages.LanguageLevelId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return JobSekeerLanguagesReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




