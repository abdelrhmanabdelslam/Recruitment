using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyTypeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyTypeMapping : IDisposable, ICompanyTypeMapping
    {
        public List<CompanyTypeReturnDTO> MappingCompanyTypeToCompanyTypeReturnDTO(List<CompanyType> CompanyTypeList)
        {

            List<CompanyTypeReturnDTO> CompanyTypeReturnDTOList = null;
            try
            {
                if (CompanyTypeList.Any() && CompanyTypeList != null)
                {
                    CompanyTypeReturnDTOList = CompanyTypeList.Select(u => new CompanyTypeReturnDTO
                    {
                        CompanyTypeId = u.CompanyTypeId,
                        CompanyTypeName  = u.CompanyTypeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyTypeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyType></returns>
        public CompanyType MappingCompanyTypeAddDTOToCompanyType(CompanyTypeAddDTO CompanyTypeAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyType CompanyType = null;
                #endregion
                try
                {
                    CompanyType = new CompanyType
                    {
                        CompanyTypeName = CompanyTypeAddDTO.CompanyTypeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyType;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyType MappingCompanyTypeupdateDTOToCompanyType(CompanyType companyType, CompanyTypeUpdateDTO CompanyTypeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyType CompanyType = companyType;
                #endregion
                try
                {
                    if (CompanyTypeUpdateDTO.CompanyTypeId > default(int))
                    {
                        CompanyType.CompanyTypeId = CompanyTypeUpdateDTO.CompanyTypeId;
                        CompanyType.CompanyTypeName = CompanyTypeUpdateDTO.CompanyTypeName;
                    }
                }
                catch (Exception exception) { }
                return CompanyType;
            }
            public CompanyTypeReturnDTO MappingCompanyTypeToCompanyTypeReturnDTO(CompanyType CompanyType)
            {
                #region Declare a return type with initial value.
                CompanyTypeReturnDTO CompanyTypeReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyType != null)
                    {
                        CompanyTypeReturnDTO = new CompanyTypeReturnDTO
                        {
                            CompanyTypeId = CompanyType.CompanyTypeId,
                            CompanyTypeName = CompanyType.CompanyTypeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyTypeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




