using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanySizeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanySizeMapping : IDisposable, ICompanySizeMapping
    {
        public List<CompanySizeReturnDTO> MappingCompanySizeToCompanySizeReturnDTO(List<CompanySize> CompanySizeList)
        {

            List<CompanySizeReturnDTO> CompanySizeReturnDTOList = null;
            try
            {
                if (CompanySizeList.Any() && CompanySizeList != null)
                {
                    CompanySizeReturnDTOList = CompanySizeList.Select(u => new CompanySizeReturnDTO
                    {
                        CompanySizeId = u.CompanySizeId,
                        CompanySizeName  = u.CompanySizeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanySizeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanySize></returns>
        public CompanySize MappingCompanySizeAddDTOToCompanySize(CompanySizeAddDTO CompanySizeAddDTO)
            {
                #region Declare a return type with initial value.
                CompanySize CompanySize = null;
                #endregion
                try
                {
                    CompanySize = new CompanySize
                    {
                        CompanySizeName = CompanySizeAddDTO.CompanySizeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanySize;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanySize MappingCompanySizeupdateDTOToCompanySize(CompanySize companySize, CompanySizeUpdateDTO CompanySizeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanySize CompanySize = companySize;
                #endregion
                try
                {
                    if (CompanySizeUpdateDTO.CompanySizeId > default(int))
                    {
                        CompanySize.CompanySizeId = CompanySizeUpdateDTO.CompanySizeId;
                        CompanySize.CompanySizeName = CompanySizeUpdateDTO.CompanySizeName;
                    }
                }
                catch (Exception exception) { }
                return CompanySize;
            }
            public CompanySizeReturnDTO MappingCompanySizeToCompanySizeReturnDTO(CompanySize CompanySize)
            {
                #region Declare a return type with initial value.
                CompanySizeReturnDTO CompanySizeReturnDTO = null;
                #endregion
                try
                {
                    if (CompanySize != null)
                    {
                        CompanySizeReturnDTO = new CompanySizeReturnDTO
                        {
                            CompanySizeId = CompanySize.CompanySizeId,
                            CompanySizeName = CompanySize.CompanySizeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanySizeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




