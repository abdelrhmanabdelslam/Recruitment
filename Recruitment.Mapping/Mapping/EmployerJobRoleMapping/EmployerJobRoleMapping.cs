using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.EmployerJobRoleDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class EmployerJobRoleMapping : IDisposable, IEmployerJobRoleMapping
    {
        public List<EmployerJobRoleReturnDTO> MappingEmployerJobRoleToEmployerJobRoleReturnDTO(List<EmployerJobRole> EmployerJobRoleList)
        {

            List<EmployerJobRoleReturnDTO> EmployerJobRoleReturnDTOList = null;
            try
            {
                if (EmployerJobRoleList.Any() && EmployerJobRoleList != null)
                {
                    EmployerJobRoleReturnDTOList = EmployerJobRoleList.Select(u => new EmployerJobRoleReturnDTO
                    {
                        EmployerJobRoleId = u.EmployerJobRoleId,
                        EmployerId = (int)u.EmployerId,
                        JobRoleId = (int)u.JobRoleId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return EmployerJobRoleReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<EmployerJobRole></returns>
        public EmployerJobRole MappingEmployerJobRoleAddDTOToEmployerJobRole(EmployerJobRoleAddDTO EmployerJobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                EmployerJobRole EmployerJobRole = null;
                #endregion
                try
                {
                    EmployerJobRole = new EmployerJobRole
                    {
                        EmployerId = EmployerJobRoleAddDTO.EmployerId,
                        JobRoleId= EmployerJobRoleAddDTO.JobRoleId ,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return EmployerJobRole;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public EmployerJobRole MappingEmployerJobRoleupdateDTOToEmployerJobRole(EmployerJobRole employerJobRole, EmployerJobRoleUpdateDTO EmployerJobRoleUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                EmployerJobRole EmployerJobRole = employerJobRole;
                #endregion
                try
                {
                    if (EmployerJobRoleUpdateDTO.EmployerJobRoleId > default(int))
                    {
                        EmployerJobRole.EmployerJobRoleId = EmployerJobRoleUpdateDTO.EmployerJobRoleId;
                        EmployerJobRole.EmployerId = EmployerJobRoleUpdateDTO.EmployerId;
                        EmployerJobRole.JobRoleId = EmployerJobRoleUpdateDTO.EmployerId;
                    }
                }
                catch (Exception exception) { }
                return EmployerJobRole;
            }
            public EmployerJobRoleReturnDTO MappingEmployerJobRoleToEmployerJobRoleReturnDTO(EmployerJobRole EmployerJobRole)
            {
                #region Declare a return type with initial value.
                EmployerJobRoleReturnDTO EmployerJobRoleReturnDTO = null;
                #endregion
                try
                {
                    if (EmployerJobRole != null)
                    {
                        EmployerJobRoleReturnDTO = new EmployerJobRoleReturnDTO
                        {
                            EmployerJobRoleId = EmployerJobRole.EmployerJobRoleId,
                            EmployerId = (int)EmployerJobRole.EmployerId,
                            JobRoleId = (int)EmployerJobRole.JobRoleId,
                        };
                    }
                }
                catch (Exception exception)
                { }
                return EmployerJobRoleReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




