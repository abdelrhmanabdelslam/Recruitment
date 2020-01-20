using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.GradeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class GradeMapping : IDisposable, IGradeMapping
    {
        public List<GradeReturnDTO> MappingGradeToGradeReturnDTO(List<Grade> GradeList)
        {

            List<GradeReturnDTO> GradeReturnDTOList = null;
            try
            {
                if (GradeList.Any() && GradeList != null)
                {
                    GradeReturnDTOList = GradeList.Select(u => new GradeReturnDTO
                    {
                        GradeId = (byte)u.GradeId,
                        GradeName  = u.GradeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return GradeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Grade></returns>
        public Grade MappingGradeAddDTOToGrade(GradeAddDTO GradeAddDTO)
            {
                #region Declare a return type with initial value.
                Grade Grade = null;
                #endregion
                try
                {
                    Grade = new Grade
                    {
                        GradeName = GradeAddDTO.GradeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Grade;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Grade MappingGradeupdateDTOToGrade(Grade grade, GradeUpdateDTO GradeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Grade Grade = grade;
                #endregion
                try
                {
                    if (GradeUpdateDTO.GradeId > default(int))
                    {
                        Grade.GradeId = GradeUpdateDTO.GradeId;
                        Grade.GradeName = GradeUpdateDTO.GradeName;
                    }
                }
                catch (Exception exception) { }
                return Grade;
            }
            public GradeReturnDTO MappingGradeToGradeReturnDTO(Grade Grade)
            {
                #region Declare a return type with initial value.
                GradeReturnDTO GradeReturnDTO = null;
                #endregion
                try
                {
                    if (Grade != null)
                    {
                        GradeReturnDTO = new GradeReturnDTO
                        {
                            GradeId =(byte) Grade.GradeId,
                            GradeName = Grade.GradeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return GradeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




