using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.EmployerJobRoleDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class EmployerJobRoleBusinessMapping : BaseBusinessMapping, IEmployerJobRoleBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IEmployerJobRoleMapping EmployerJobRoleMapping { get; }
        #endregion

        #region Constructor
        public EmployerJobRoleBusinessMapping(IUnitOfWork unitOfWork, IEmployerJobRoleMapping employerJobRoleMapping)
        {
            UnitOfWork = unitOfWork;
            EmployerJobRoleMapping = employerJobRoleMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<EmployerJobRoleReturnDTO></returns>
        public async Task<List<EmployerJobRoleReturnDTO>> GetAllEmployerJobRoles()
        {
            #region Declare Return Var with Intial Value
            List<EmployerJobRoleReturnDTO> allEmployerJobRoles = null;
            #endregion
            try
            {
                #region Vars
                List<EmployerJobRole> EmployerJobRoleList = null;
                #endregion
                EmployerJobRoleList = await UnitOfWork.EmployerJobRoleRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (EmployerJobRoleList != null && EmployerJobRoleList.Any())
                {
                    allEmployerJobRoles = EmployerJobRoleMapping.MappingEmployerJobRoleToEmployerJobRoleReturnDTO(EmployerJobRoleList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allEmployerJobRoles;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddEmployerJobRole(EmployerJobRoleAddDTO EmployerJobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                bool isEmployerJobRoleCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    EmployerJobRole EmployerJobRole = null;
                    #endregion
                    EmployerJobRole = EmployerJobRoleMapping.MappingEmployerJobRoleAddDTOToEmployerJobRole(EmployerJobRoleAddDTO);
                    if (EmployerJobRole != null)
                    {
                        await UnitOfWork.EmployerJobRoleRepository.Insert(EmployerJobRole);
                        isEmployerJobRoleCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerJobRoleCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<EmployerJobRoleReturnDTO></returns>
            public async Task<EmployerJobRoleReturnDTO> GetEmployerJobRoleById(int EmployerJobRoleId)
            {
                #region Declare a return type with initial value.
                EmployerJobRoleReturnDTO EmployerJobRole = new EmployerJobRoleReturnDTO();
                #endregion
                try
                {
                    EmployerJobRole employerJobRole = await UnitOfWork.EmployerJobRoleRepository.GetById(EmployerJobRoleId);
                    if (employerJobRole != null)
                    {
                        if (employerJobRole.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            EmployerJobRole = EmployerJobRoleMapping.MappingEmployerJobRoleToEmployerJobRoleReturnDTO(employerJobRole);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return EmployerJobRole;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateEmployerJobRole(EmployerJobRoleUpdateDTO EmployerJobRoleUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isEmployerJobRoleUpdated = default(bool);
                #endregion
                try
                {
                    if (EmployerJobRoleUpdateDTO != null)
                    {
                        #region Vars
                        EmployerJobRole EmployerJobRole = null;
                        #endregion
                        #region Get Activity By Id
                        EmployerJobRole = await UnitOfWork.EmployerJobRoleRepository.GetById(EmployerJobRoleUpdateDTO.EmployerJobRoleId);
                        #endregion
                        if (EmployerJobRole != null)
                        {
                            #region  Mapping
                            EmployerJobRole = EmployerJobRoleMapping.MappingEmployerJobRoleupdateDTOToEmployerJobRole(EmployerJobRole ,EmployerJobRoleUpdateDTO);
                            #endregion
                            if (EmployerJobRole != null)
                            {
                                #region  Update Entity
                                UnitOfWork.EmployerJobRoleRepository.Update(EmployerJobRole);
                                isEmployerJobRoleUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerJobRoleUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteEmployerJobRole(int EmployerJobRoleId)
            {
                #region Declare a return type with initial value.
                bool isEmployerJobRoleDeleted = default(bool);
                #endregion
                try
                {
                    if (EmployerJobRoleId > default(int))
                    {
                        #region Vars
                        EmployerJobRole EmployerJobRole = null;
                        #endregion
                        #region Get EmployerJobRole by id
                        EmployerJobRole = await UnitOfWork.EmployerJobRoleRepository.GetById(EmployerJobRoleId);
                        #endregion
                        #region check if object is not null
                        if (EmployerJobRole != null)
                        {
                            EmployerJobRole.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.EmployerJobRoleRepository.Update(EmployerJobRole);
                            isEmployerJobRoleDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isEmployerJobRoleDeleted;
            }
#endregion
        }
    }




