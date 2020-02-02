using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerGradeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerGradeBusinessMapping : BaseBusinessMapping, IJobSeekerGradeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerGradeMapping JobSeekerGradeMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerGradeBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerGradeMapping jobSeekerGradeMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerGradeMapping = jobSeekerGradeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerGradeReturnDTO></returns>
        public async Task<List<JobSeekerGradeReturnDTO>> GetAllJobSeekerGrades()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerGradeReturnDTO> allJobSeekerGrades = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerGrade> JobSeekerGradeList = null;
                #endregion
                JobSeekerGradeList = await UnitOfWork.JobSeekerGradeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerGradeList != null && JobSeekerGradeList.Any())
                {
                    allJobSeekerGrades = JobSeekerGradeMapping.MappingJobSeekerGradeToJobSeekerGradeReturnDTO(JobSeekerGradeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerGrades;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerGrade(JobSeekerGradeAddDTO JobSeekerGradeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerGradeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerGrade JobSeekerGrade = null;
                    #endregion
                    JobSeekerGrade = JobSeekerGradeMapping.MappingJobSeekerGradeAddDTOToJobSeekerGrade(JobSeekerGradeAddDTO);
                    if (JobSeekerGrade != null)
                    {
                        await UnitOfWork.JobSeekerGradeRepository.Insert(JobSeekerGrade);
                        isJobSeekerGradeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerGradeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerGradeReturnDTO></returns>
            public async Task<JobSeekerGradeReturnDTO> GetJobSeekerGradeById(int JobSeekerGradeId)
            {
                #region Declare a return type with initial value.
                JobSeekerGradeReturnDTO JobSeekerGrade = new JobSeekerGradeReturnDTO();
                #endregion
                try
                {
                    JobSeekerGrade jobSeekerGrade = await UnitOfWork.JobSeekerGradeRepository.GetById(JobSeekerGradeId);
                    if (jobSeekerGrade != null)
                    {
                        if (jobSeekerGrade.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerGrade = JobSeekerGradeMapping.MappingJobSeekerGradeToJobSeekerGradeReturnDTO(jobSeekerGrade);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerGrade;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerGrade(JobSeekerGradeUpdateDTO JobSeekerGradeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerGradeUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerGradeUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerGrade JobSeekerGrade = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerGrade = await UnitOfWork.JobSeekerGradeRepository.GetById(JobSeekerGradeUpdateDTO.JobSeekerGradeId);
                        #endregion
                        if (JobSeekerGrade != null)
                        {
                            #region  Mapping
                            JobSeekerGrade = JobSeekerGradeMapping.MappingJobSeekerGradeupdateDTOToJobSeekerGrade(JobSeekerGrade ,JobSeekerGradeUpdateDTO);
                            #endregion
                            if (JobSeekerGrade != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerGradeRepository.Update(JobSeekerGrade);
                                isJobSeekerGradeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerGradeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerGrade(int JobSeekerGradeId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerGradeDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerGradeId > default(int))
                    {
                        #region Vars
                        JobSeekerGrade JobSeekerGrade = null;
                        #endregion
                        #region Get JobSeekerGrade by id
                        JobSeekerGrade = await UnitOfWork.JobSeekerGradeRepository.GetById(JobSeekerGradeId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerGrade != null)
                        {
                            JobSeekerGrade.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerGradeRepository.Update(JobSeekerGrade);
                            isJobSeekerGradeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerGradeDeleted;
            }
#endregion
        }
    }




