using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.TypeOfJobDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class TypeOfJobBusinessMapping : BaseBusinessMapping, ITypeOfJobBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ITypeOfJobMapping TypeOfJobMapping { get; }
        #endregion

        #region Constructor
        public TypeOfJobBusinessMapping(IUnitOfWork unitOfWork, ITypeOfJobMapping typeOfJobMapping)
        {
            UnitOfWork = unitOfWork;
            TypeOfJobMapping = typeOfJobMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<TypeOfJobReturnDTO></returns>
        public async Task<List<TypeOfJobReturnDTO>> GetAllTypeOfJobs()
        {
            #region Declare Return Var with Intial Value
            List<TypeOfJobReturnDTO> allTypeOfJobs = null;
            #endregion
            try
            {
                #region Vars
                List<TypeOfJob> TypeOfJobList = null;
                #endregion
                TypeOfJobList = await UnitOfWork.TypeOfJobRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (TypeOfJobList != null && TypeOfJobList.Any())
                {
                    allTypeOfJobs = TypeOfJobMapping.MappingTypeOfJobToTypeOfJobReturnDTO(TypeOfJobList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allTypeOfJobs;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddTypeOfJob(TypeOfJobAddDTO TypeOfJobAddDTO)
            {
                #region Declare a return type with initial value.
                bool isTypeOfJobCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    TypeOfJob TypeOfJob = null;
                    #endregion
                    TypeOfJob = TypeOfJobMapping.MappingTypeOfJobAddDTOToTypeOfJob(TypeOfJobAddDTO);
                    if (TypeOfJob != null)
                    {
                        await UnitOfWork.TypeOfJobRepository.Insert(TypeOfJob);
                        isTypeOfJobCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isTypeOfJobCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<TypeOfJobReturnDTO></returns>
            public async Task<TypeOfJobReturnDTO> GetTypeOfJobById(int TypeOfJobId)
            {
                #region Declare a return type with initial value.
                TypeOfJobReturnDTO TypeOfJob = new TypeOfJobReturnDTO();
                #endregion
                try
                {
                    TypeOfJob typeOfJob = await UnitOfWork.TypeOfJobRepository.GetById(TypeOfJobId);
                    if (typeOfJob != null)
                    {
                        if (typeOfJob.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            TypeOfJob = TypeOfJobMapping.MappingTypeOfJobToTypeOfJobReturnDTO(typeOfJob);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return TypeOfJob;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateTypeOfJob(TypeOfJobUpdateDTO TypeOfJobUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isTypeOfJobUpdated = default(bool);
                #endregion
                try
                {
                    if (TypeOfJobUpdateDTO != null)
                    {
                        #region Vars
                        TypeOfJob TypeOfJob = null;
                        #endregion
                        #region Get Activity By Id
                        TypeOfJob = await UnitOfWork.TypeOfJobRepository.GetById(TypeOfJobUpdateDTO.TypeOfJobId);
                        #endregion
                        if (TypeOfJob != null)
                        {
                            #region  Mapping
                            TypeOfJob = TypeOfJobMapping.MappingTypeOfJobupdateDTOToTypeOfJob(TypeOfJob ,TypeOfJobUpdateDTO);
                            #endregion
                            if (TypeOfJob != null)
                            {
                                #region  Update Entity
                                UnitOfWork.TypeOfJobRepository.Update(TypeOfJob);
                                isTypeOfJobUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isTypeOfJobUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteTypeOfJob(int TypeOfJobId)
            {
                #region Declare a return type with initial value.
                bool isTypeOfJobDeleted = default(bool);
                #endregion
                try
                {
                    if (TypeOfJobId > default(int))
                    {
                        #region Vars
                        TypeOfJob TypeOfJob = null;
                        #endregion
                        #region Get TypeOfJob by id
                        TypeOfJob = await UnitOfWork.TypeOfJobRepository.GetById(TypeOfJobId);
                        #endregion
                        #region check if object is not null
                        if (TypeOfJob != null)
                        {
                            TypeOfJob.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.TypeOfJobRepository.Update(TypeOfJob);
                            isTypeOfJobDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isTypeOfJobDeleted;
            }
#endregion
        }
    }




