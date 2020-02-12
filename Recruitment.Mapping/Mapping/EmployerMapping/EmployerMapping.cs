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
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        EmployerId = u.EmployerId ,
                        BusinessEmail = u.BusinessEmail,
                        MobileNumber = u.MobileNumber,
                        MobileNumber1 = u.MobileNumber1,
                        ReferralId = u.ReferralId,
                        Title = u.Title
                       
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
                        FirstName = EmployerAddDTO.FirstName,
                        LastName = EmployerAddDTO.LastName,
                        BusinessEmail = EmployerAddDTO.BusinessEmail,
                        MobileNumber = EmployerAddDTO.MobileNumber,
                        MobileNumber1 = EmployerAddDTO.MobileNumber1,
                        ReferralId = EmployerAddDTO.ReferralId,
                        Title = EmployerAddDTO.Title,
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
                        Employer.FirstName = EmployerUpdateDTO.FirstName;
                        Employer.LastName = EmployerUpdateDTO.LastName;
                        Employer.EmployerId = EmployerUpdateDTO.EmployerId;
                        Employer.BusinessEmail = EmployerUpdateDTO.BusinessEmail;
                        Employer.MobileNumber = EmployerUpdateDTO.MobileNumber;
                        Employer.MobileNumber1 = EmployerUpdateDTO.MobileNumber1;
                        Employer.ReferralId = EmployerUpdateDTO.ReferralId;
                        Employer.Title = EmployerUpdateDTO.Title;
                    
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
                            FirstName = Employer.FirstName,
                            LastName = Employer.LastName,
                            BusinessEmail = Employer.BusinessEmail,
                            MobileNumber = Employer.MobileNumber,
                            MobileNumber1 = Employer.MobileNumber1,
                            ReferralId = Employer.ReferralId,
                            Title = Employer.Title,
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




