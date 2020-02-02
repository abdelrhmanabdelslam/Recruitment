using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.TypeOfJobDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class TypeOfJobMapping : IDisposable, ITypeOfJobMapping
    {
        public List<TypeOfJobReturnDTO> MappingTypeOfJobToTypeOfJobReturnDTO(List<TypeOfJob> TypeOfJobList)
        {

            List<TypeOfJobReturnDTO> TypeOfJobReturnDTOList = null;
            try
            {
                if (TypeOfJobList.Any() && TypeOfJobList != null)
                {
                    TypeOfJobReturnDTOList = TypeOfJobList.Select(u => new TypeOfJobReturnDTO
                    {
                        TypeOfJobId = u.TypeOfJobId,
                        TypeOfJobName  = u.TypeOfJobName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return TypeOfJobReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<TypeOfJob></returns>
        public TypeOfJob MappingTypeOfJobAddDTOToTypeOfJob(TypeOfJobAddDTO TypeOfJobAddDTO)
            {
                #region Declare a return type with initial value.
                TypeOfJob TypeOfJob = null;
                #endregion
                try
                {
                    TypeOfJob = new TypeOfJob
                    {
                        TypeOfJobName = TypeOfJobAddDTO.TypeOfJobName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return TypeOfJob;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public TypeOfJob MappingTypeOfJobupdateDTOToTypeOfJob(TypeOfJob typeOfJob, TypeOfJobUpdateDTO TypeOfJobUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                TypeOfJob TypeOfJob = typeOfJob;
                #endregion
                try
                {
                    if (TypeOfJobUpdateDTO.TypeOfJobId > default(int))
                    {
                        TypeOfJob.TypeOfJobId = TypeOfJobUpdateDTO.TypeOfJobId;
                        TypeOfJob.TypeOfJobName = TypeOfJobUpdateDTO.TypeOfJobName;
                    }
                }
                catch (Exception exception) { }
                return TypeOfJob;
            }
            public TypeOfJobReturnDTO MappingTypeOfJobToTypeOfJobReturnDTO(TypeOfJob TypeOfJob)
            {
                #region Declare a return type with initial value.
                TypeOfJobReturnDTO TypeOfJobReturnDTO = null;
                #endregion
                try
                {
                    if (TypeOfJob != null)
                    {
                        TypeOfJobReturnDTO = new TypeOfJobReturnDTO
                        {
                            TypeOfJobId = TypeOfJob.TypeOfJobId,
                            TypeOfJobName = TypeOfJob.TypeOfJobName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return TypeOfJobReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




