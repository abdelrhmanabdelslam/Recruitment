using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.IndustryDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class IndustryMapping : IDisposable, IIndustryMapping
    {
        public List<IndustryReturnDTO> MappingIndustryToIndustryReturnDTO(List<Industry> IndustryList)
        {

            List<IndustryReturnDTO> IndustryReturnDTOList = null;
            try
            {
                if (IndustryList.Any() && IndustryList != null)
                {
                    IndustryReturnDTOList = IndustryList.Select(u => new IndustryReturnDTO
                    {
                        IndustryId = u.IndustryId,
                        IndustryName  = u.IndustryName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return IndustryReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name="></param>
        /// <returns>Task<Industry></returns>
        public Industry MappingIndustryAddDTOToIndustry(GradeAddDTO IndustryAddDTO)
            {
                #region Declare a return type with initial value.
                Industry Industry = null;
                #endregion
                try
                {
                    Industry = new Industry
                    {
                        IndustryName  = IndustryAddDTO.IndustryName ,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception)  {}
                return Industry;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name="></param>
            /// <param name="></param>
            /// <returns></returns>
            public Industry MappingIndustryupdateDTOToIndustry(Industry industry,GradeUpdateDTO IndustryUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Industry Industry = industry;
                #endregion
                try
                {
                if (IndustryUpdateDTO.IndustryId  > default(int) )
                {
                    Industry.IndustryId  = IndustryUpdateDTO.IndustryId ;
                    Industry.IndustryName  = IndustryUpdateDTO.IndustryName ;
                }
            }
                catch (Exception exception) {}
                return Industry;
            }
            public IndustryReturnDTO MappingIndustryToIndustryReturnDTO(Industry Industry)
            {
                #region Declare a return type with initial value.
                IndustryReturnDTO IndustryReturnDTO = null;
                #endregion
                try
                {
                    if (Industry != null)
                    {
                        IndustryReturnDTO = new IndustryReturnDTO
                        {
                            IndustryId = Industry.IndustryId,
                            IndustryName = Industry.IndustryName
                        };
                    }
                }
                catch (Exception exception)
                {}
                return IndustryReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }


