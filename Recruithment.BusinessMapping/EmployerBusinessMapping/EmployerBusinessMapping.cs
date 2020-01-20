using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.EmployerDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class EmployerBusinessMapping : BaseBusinessMapping, IEmployerBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IEmployerMapping EmployerMapping { get; }
        #endregion

        #region Constructor
        public EmployerBusinessMapping(IUnitOfWork unitOfWork, IEmployerMapping employerMapping)
        {
            UnitOfWork = unitOfWork;
            EmployerMapping = employerMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<EmployerReturnDTO></returns>
        public async Task<List<EmployerReturnDTO>> GetAllEmployers()
        {
            #region Declare Return Var with Intial Value
            List<EmployerReturnDTO> allEmployers = null;
            #endregion
            try
            {
                #region Vars
                List<Employer> EmployerList = null;
                #endregion
                EmployerList = await UnitOfWork.EmployerRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (EmployerList != null && EmployerList.Any())
                {
                    allEmployers = EmployerMapping.MappingEmployerToEmployerReturnDTO(EmployerList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allEmployers;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddEmployer(EmployerAddDTO EmployerAddDTO)
            {
                #region Declare a return type with initial value.
                bool isEmployerCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Employer Employer = null;
                    #endregion
                    Employer = EmployerMapping.MappingEmployerAddDTOToEmployer(EmployerAddDTO);
                    if (Employer != null)
                    {
                        await UnitOfWork.EmployerRepository.Insert(Employer);
                        isEmployerCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<EmployerReturnDTO></returns>
            public async Task<EmployerReturnDTO> GetEmployerById(int EmployerId)
            {
                #region Declare a return type with initial value.
                EmployerReturnDTO Employer = new EmployerReturnDTO();
                #endregion
                try
                {
                    Employer employer = await UnitOfWork.EmployerRepository.GetById(EmployerId);
                    if (employer != null)
                    {
                        if (employer.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Employer = EmployerMapping.MappingEmployerToEmployerReturnDTO(employer);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Employer;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateEmployer(EmployerUpdateDTO EmployerUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isEmployerUpdated = default(bool);
                #endregion
                try
                {
                    if (EmployerUpdateDTO != null)
                    {
                        #region Vars
                        Employer Employer = null;
                        #endregion
                        #region Get Activity By Id
                        Employer = await UnitOfWork.EmployerRepository.GetById(EmployerUpdateDTO.EmployerId);
                        #endregion
                        if (Employer != null)
                        {
                            #region  Mapping
                            Employer = EmployerMapping.MappingEmployerupdateDTOToEmployer(Employer ,EmployerUpdateDTO);
                            #endregion
                            if (Employer != null)
                            {
                                #region  Update Entity
                                UnitOfWork.EmployerRepository.Update(Employer);
                                isEmployerUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteEmployer(int EmployerId)
            {
                #region Declare a return type with initial value.
                bool isEmployerDeleted = default(bool);
                #endregion
                try
                {
                    if (EmployerId > default(int))
                    {
                        #region Vars
                        Employer Employer = null;
                        #endregion
                        #region Get Employer by id
                        Employer = await UnitOfWork.EmployerRepository.GetById(EmployerId);
                        #endregion
                        #region check if object is not null
                        if (Employer != null)
                        {
                            Employer.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.EmployerRepository.Update(Employer);
                            isEmployerDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerDeleted;
            }
#endregion
        }
    }




