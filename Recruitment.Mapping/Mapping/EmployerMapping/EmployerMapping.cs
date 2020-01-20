using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.EmployerDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class EmployerMapping : IDisposable, IEmployerMapping
    {
        public List<EmployerReturnDTO> MappingEmployerToEmployerReturnDTO(List<Employer> EmployerList)
        {

            List<EmployerReturnDTO> EmployerReturnDTOList = null;
            try
            {
                if (EmployerList.Any() && EmployerList != null)
                {
                    EmployerReturnDTOList = EmployerList.Select(u => new EmployerReturnDTO
                    {
                        EmployerId = u.EmployerId,
                        EmployerName  = u.EmployerName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return EmployerReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Employer></returns>
        public Employer MappingEmployerAddDTOToEmployer(EmployerAddDTO EmployerAddDTO)
            {
                #region Declare a return type with initial value.
                Employer Employer = null;
                #endregion
                try
                {
                    Employer = new Employer
                    {
                        EmployerName = EmployerAddDTO.EmployerName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Employer;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Employer MappingEmployerupdateDTOToEmployer(Employer employer, EmployerUpdateDTO EmployerUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Employer Employer = employer;
                #endregion
                try
                {
                    if (EmployerUpdateDTO.EmployerId > default(int))
                    {
                        Employer.EmployerId = EmployerUpdateDTO.EmployerId;
                        Employer.EmployerName = EmployerUpdateDTO.EmployerName;
                    }
                }
                catch (Exception exception) { }
                return Employer;
            }
            public EmployerReturnDTO MappingEmployerToEmployerReturnDTO(Employer Employer)
            {
                #region Declare a return type with initial value.
                EmployerReturnDTO EmployerReturnDTO = null;
                #endregion
                try
                {
                    if (Employer != null)
                    {
                        EmployerReturnDTO = new EmployerReturnDTO
                        {
                            EmployerId = Employer.EmployerId,
                            EmployerName = Employer.EmployerName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return EmployerReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




