using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyUserTypeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyUserTypeMapping : IDisposable, ICompanyUserTypeMapping
    {
        public List<CompanyUserTypeReturnDTO> MappingCompanyUserTypeToCompanyUserTypeReturnDTO(List<CompanyUserType> CompanyUserTypeList)
        {

            List<CompanyUserTypeReturnDTO> CompanyUserTypeReturnDTOList = null;
            try
            {
                if (CompanyUserTypeList.Any() && CompanyUserTypeList != null)
                {
                    CompanyUserTypeReturnDTOList = CompanyUserTypeList.Select(u => new CompanyUserTypeReturnDTO
                    {
                        CompanyUserTypeId = u.CompanyUserTypeId,
                        CompanyUserTypeName  = u.CompanyUserTypeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyUserTypeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyUserType></returns>
        public CompanyUserType MappingCompanyUserTypeAddDTOToCompanyUserType(CompanyUserTypeAddDTO CompanyUserTypeAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyUserType CompanyUserType = null;
                #endregion
                try
                {
                    CompanyUserType = new CompanyUserType
                    {
                        CompanyUserTypeName = CompanyUserTypeAddDTO.CompanyUserTypeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyUserType;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyUserType MappingCompanyUserTypeupdateDTOToCompanyUserType(CompanyUserType companyUserType, CompanyUserTypeUpdateDTO CompanyUserTypeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyUserType CompanyUserType = companyUserType;
                #endregion
                try
                {
                    if (CompanyUserTypeUpdateDTO.CompanyUserTypeId > default(int))
                    {
                        CompanyUserType.CompanyUserTypeId = CompanyUserTypeUpdateDTO.CompanyUserTypeId;
                        CompanyUserType.CompanyUserTypeName = CompanyUserTypeUpdateDTO.CompanyUserTypeName;
                    }
                }
                catch (Exception exception) { }
                return CompanyUserType;
            }
            public CompanyUserTypeReturnDTO MappingCompanyUserTypeToCompanyUserTypeReturnDTO(CompanyUserType CompanyUserType)
            {
                #region Declare a return type with initial value.
                CompanyUserTypeReturnDTO CompanyUserTypeReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyUserType != null)
                    {
                        CompanyUserTypeReturnDTO = new CompanyUserTypeReturnDTO
                        {
                            CompanyUserTypeId = CompanyUserType.CompanyUserTypeId,
                            CompanyUserTypeName = CompanyUserType.CompanyUserTypeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyUserTypeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




