using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyIndustryDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyIndustryMapping : IDisposable, ICompanyIndustryMapping
    {
        public List<CompanyIndustryReturnDTO> MappingCompanyIndustryToCompanyIndustryReturnDTO(List<CompanyIndustry> CompanyIndustryList)
        {

            List<CompanyIndustryReturnDTO> CompanyIndustryReturnDTOList = null;
            try
            {
                if (CompanyIndustryList.Any() && CompanyIndustryList != null)
                {
                    CompanyIndustryReturnDTOList = CompanyIndustryList.Select(u => new CompanyIndustryReturnDTO
                    {
                       CompanyIndustryId = u.CompanyIndustryId ,
                        CompanyInformationId= u.CompanyInformationId ,
                        IndustryId = u.IndustryId 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyIndustryReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyIndustry></returns>
        public CompanyIndustry MappingCompanyIndustryAddDTOToCompanyIndustry(CompanyIndustryAddDTO CompanyIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyIndustry CompanyIndustry = null;
                #endregion
                try
                {
                    CompanyIndustry = new CompanyIndustry
                    {
                        IndustryId = CompanyIndustryAddDTO.IndustryId,
                        CompanyInformationId = CompanyIndustryAddDTO.CompanyInformationId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyIndustry;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyIndustry MappingCompanyIndustryupdateDTOToCompanyIndustry(CompanyIndustry companyIndustry, CompanyIndustryUpdateDTO CompanyIndustryUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyIndustry CompanyIndustry = companyIndustry;
                #endregion
                try
                {
                    if (CompanyIndustryUpdateDTO.CompanyIndustryId > default(int))
                    {
                        CompanyIndustry.IndustryId = CompanyIndustryUpdateDTO.IndustryId;
                        CompanyIndustry.CompanyIndustryId = CompanyIndustryUpdateDTO.CompanyIndustryId;
                        CompanyIndustry.CompanyInformationId = CompanyIndustryUpdateDTO.CompanyInformationId;
                    }
                }
                catch (Exception exception) { }
                return CompanyIndustry;
            }
            public CompanyIndustryReturnDTO MappingCompanyIndustryToCompanyIndustryReturnDTO(CompanyIndustry CompanyIndustry)
            {
                #region Declare a return type with initial value.
                CompanyIndustryReturnDTO CompanyIndustryReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyIndustry != null)
                    {
                        CompanyIndustryReturnDTO = new CompanyIndustryReturnDTO
                        {
                            CompanyIndustryId = CompanyIndustry.CompanyIndustryId,
                            IndustryId = CompanyIndustry.IndustryId,
                            CompanyInformationId = CompanyIndustry.CompanyInformationId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyIndustryReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




