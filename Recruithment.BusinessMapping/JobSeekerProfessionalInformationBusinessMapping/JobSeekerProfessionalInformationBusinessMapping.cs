using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.JobSeekerProfessionalInformationDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class JobSeekerProfessionalInformationBusinessMapping : BaseBusinessMapping, IJobSeekerProfessionalInformationBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IJobSeekerProfessionalInformationMapping JobSeekerProfessionalInformationMapping { get; }
        #endregion

        #region Constructor
        public JobSeekerProfessionalInformationBusinessMapping(IUnitOfWork unitOfWork, IJobSeekerProfessionalInformationMapping jobSeekerProfessionalInformationMapping)
        {
            UnitOfWork = unitOfWork;
            JobSeekerProfessionalInformationMapping = jobSeekerProfessionalInformationMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<JobSeekerProfessionalInformationReturnDTO></returns>
        public async Task<List<JobSeekerProfessionalInformationReturnDTO>> GetAllJobSeekerProfessionalInformations()
        {
            #region Declare Return Var with Intial Value
            List<JobSeekerProfessionalInformationReturnDTO> allJobSeekerProfessionalInformations = null;
            #endregion
            try
            {
                #region Vars
                List<JobSeekerProfessionalInformation> JobSeekerProfessionalInformationList = null;
                #endregion
                JobSeekerProfessionalInformationList = await UnitOfWork.JobSeekerProfessionalInformationRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (JobSeekerProfessionalInformationList != null && JobSeekerProfessionalInformationList.Any())
                {
                    allJobSeekerProfessionalInformations = JobSeekerProfessionalInformationMapping.MappingJobSeekerProfessionalInformationToJobSeekerProfessionalInformationReturnDTO(JobSeekerProfessionalInformationList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allJobSeekerProfessionalInformations;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO JobSeekerProfessionalInformationAddDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerProfessionalInformationCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    JobSeekerProfessionalInformation JobSeekerProfessionalInformation = null;
                    #endregion
                    JobSeekerProfessionalInformation = JobSeekerProfessionalInformationMapping.MappingJobSeekerProfessionalInformationAddDTOToJobSeekerProfessionalInformation(JobSeekerProfessionalInformationAddDTO);
                    if (JobSeekerProfessionalInformation != null)
                    {
                        await UnitOfWork.JobSeekerProfessionalInformationRepository.Insert(JobSeekerProfessionalInformation);
                        isJobSeekerProfessionalInformationCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerProfessionalInformationCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<JobSeekerProfessionalInformationReturnDTO></returns>
            public async Task<JobSeekerProfessionalInformationReturnDTO> GetJobSeekerProfessionalInformationById(int JobSeekerProfessionalInformationId)
            {
                #region Declare a return type with initial value.
                JobSeekerProfessionalInformationReturnDTO JobSeekerProfessionalInformation = new JobSeekerProfessionalInformationReturnDTO();
                #endregion
                try
                {
                    JobSeekerProfessionalInformation jobSeekerProfessionalInformation = await UnitOfWork.JobSeekerProfessionalInformationRepository.GetById(JobSeekerProfessionalInformationId);
                    if (jobSeekerProfessionalInformation != null)
                    {
                        if (jobSeekerProfessionalInformation.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            JobSeekerProfessionalInformation = JobSeekerProfessionalInformationMapping.MappingJobSeekerProfessionalInformationToJobSeekerProfessionalInformationReturnDTO(jobSeekerProfessionalInformation);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return JobSeekerProfessionalInformation;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateJobSeekerProfessionalInformation(JobSeekerProfessionalInformationUpdateDTO JobSeekerProfessionalInformationUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerProfessionalInformationUpdated = default(bool);
                #endregion
                try
                {
                    if (JobSeekerProfessionalInformationUpdateDTO != null)
                    {
                        #region Vars
                        JobSeekerProfessionalInformation JobSeekerProfessionalInformation = null;
                        #endregion
                        #region Get Activity By Id
                        JobSeekerProfessionalInformation = await UnitOfWork.JobSeekerProfessionalInformationRepository.GetById((int)JobSeekerProfessionalInformationUpdateDTO.JobSeekerProfessionalInformationId);
                        #endregion
                        if (JobSeekerProfessionalInformation != null)
                        {
                            #region  Mapping
                            JobSeekerProfessionalInformation = JobSeekerProfessionalInformationMapping.MappingJobSeekerProfessionalInformationupdateDTOToJobSeekerProfessionalInformation(JobSeekerProfessionalInformation ,JobSeekerProfessionalInformationUpdateDTO);
                            #endregion
                            if (JobSeekerProfessionalInformation != null)
                            {
                                #region  Update Entity
                                UnitOfWork.JobSeekerProfessionalInformationRepository.Update(JobSeekerProfessionalInformation);
                                isJobSeekerProfessionalInformationUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerProfessionalInformationUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteJobSeekerProfessionalInformation(int JobSeekerProfessionalInformationId)
            {
                #region Declare a return type with initial value.
                bool isJobSeekerProfessionalInformationDeleted = default(bool);
                #endregion
                try
                {
                    if (JobSeekerProfessionalInformationId > default(int))
                    {
                        #region Vars
                        JobSeekerProfessionalInformation JobSeekerProfessionalInformation = null;
                        #endregion
                        #region Get JobSeekerProfessionalInformation by id
                        JobSeekerProfessionalInformation = await UnitOfWork.JobSeekerProfessionalInformationRepository.GetById(JobSeekerProfessionalInformationId);
                        #endregion
                        #region check if object is not null
                        if (JobSeekerProfessionalInformation != null)
                        {
                            JobSeekerProfessionalInformation.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.JobSeekerProfessionalInformationRepository.Update(JobSeekerProfessionalInformation);
                            isJobSeekerProfessionalInformationDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isJobSeekerProfessionalInformationDeleted;
            }
#endregion
        }
    }




