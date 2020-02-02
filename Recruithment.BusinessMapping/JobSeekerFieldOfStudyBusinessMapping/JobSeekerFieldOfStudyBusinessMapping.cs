using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerFieldOfStudyDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerFieldOfStudyBusinessMapping : BaseBusinessMapping, IJobSeekerFieldOfStudyBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerFieldOfStudyMapping JobSeekerFieldOfStudyMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerFieldOfStudyBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerFieldOfStudyMapping jobSeekerFieldOfStudyMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerFieldOfStudyMapping = jobSeekerFieldOfStudyMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerFieldOfStudyReturnDTO></returns>
        public async Task<List<JobSeekerFieldOfStudyReturnDTO>> GetAllJobSeekerFieldOfStudys()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerFieldOfStudyReturnDTO> allJobSeekerFieldOfStudys = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerFieldOfStudy> JobSeekerFieldOfStudyList = null;
                #endregion
                JobSeekerFieldOfStudyList = await UnitOfWork.JobSeekerFieldOfStudyRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerFieldOfStudyList != null && JobSeekerFieldOfStudyList.Any())
                {
                    allJobSeekerFieldOfStudys = JobSeekerFieldOfStudyMapping.MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(JobSeekerFieldOfStudyList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerFieldOfStudys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO JobSeekerFieldOfStudyAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerFieldOfStudyCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerFieldOfStudy JobSeekerFieldOfStudy = null;
                    #endregion
                    JobSeekerFieldOfStudy = JobSeekerFieldOfStudyMapping.MappingJobSeekerFieldOfStudyAddDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudyAddDTO);
                    if (JobSeekerFieldOfStudy != null)
                    {
                        await UnitOfWork.JobSeekerFieldOfStudyRepository.Insert(JobSeekerFieldOfStudy);
                        isJobSeekerFieldOfStudyCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerFieldOfStudyCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerFieldOfStudyReturnDTO></returns>
            public async Task<JobSeekerFieldOfStudyReturnDTO> GetJobSeekerFieldOfStudyById(int JobSeekerFieldOfStudyId)
            {
                #region Declare a return type with initial value.
                JobSeekerFieldOfStudyReturnDTO JobSeekerFieldOfStudy = new JobSeekerFieldOfStudyReturnDTO();
                #endregion
                try
                {
                    JobSeekerFieldOfStudy jobSeekerFieldOfStudy = await UnitOfWork.JobSeekerFieldOfStudyRepository.GetById(JobSeekerFieldOfStudyId);
                    if (jobSeekerFieldOfStudy != null)
                    {
                        if (jobSeekerFieldOfStudy.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerFieldOfStudy = JobSeekerFieldOfStudyMapping.MappingJobSeekerFieldOfStudyToJobSeekerFieldOfStudyReturnDTO(jobSeekerFieldOfStudy);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerFieldOfStudy;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerFieldOfStudy(JobSeekerFieldOfStudyUpdateDTO JobSeekerFieldOfStudyUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerFieldOfStudyUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerFieldOfStudyUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerFieldOfStudy JobSeekerFieldOfStudy = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerFieldOfStudy = await UnitOfWork.JobSeekerFieldOfStudyRepository.GetById(JobSeekerFieldOfStudyUpdateDTO.JobSeekerFieldOfStudyId);
                        #endregion
                        if (JobSeekerFieldOfStudy != null)
                        {
                            #region  Mapping
                            JobSeekerFieldOfStudy = JobSeekerFieldOfStudyMapping.MappingJobSeekerFieldOfStudyupdateDTOToJobSeekerFieldOfStudy(JobSeekerFieldOfStudy ,JobSeekerFieldOfStudyUpdateDTO);
                            #endregion
                            if (JobSeekerFieldOfStudy != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerFieldOfStudyRepository.Update(JobSeekerFieldOfStudy);
                                isJobSeekerFieldOfStudyUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerFieldOfStudyUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerFieldOfStudy(int JobSeekerFieldOfStudyId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerFieldOfStudyDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerFieldOfStudyId > default(int))
                    {
                        #region Vars
                        JobSeekerFieldOfStudy JobSeekerFieldOfStudy = null;
                        #endregion
                        #region Get JobSeekerFieldOfStudy by id
                        JobSeekerFieldOfStudy = await UnitOfWork.JobSeekerFieldOfStudyRepository.GetById(JobSeekerFieldOfStudyId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerFieldOfStudy != null)
                        {
                            JobSeekerFieldOfStudy.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerFieldOfStudyRepository.Update(JobSeekerFieldOfStudy);
                            isJobSeekerFieldOfStudyDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerFieldOfStudyDeleted;
            }
#endregion
        }
    }




