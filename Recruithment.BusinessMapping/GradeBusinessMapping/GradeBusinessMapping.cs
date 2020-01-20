using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.GradeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class GradeBusinessMapping : BaseBusinessMapping, IGradeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IGradeMapping GradeMapping { get; }
        #endregion

        #region Constructor
        public GradeBusinessMapping(IUnitOfWork unitOfWork, IGradeMapping gradeMapping)
        {
            UnitOfWork = unitOfWork;
            GradeMapping = gradeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<GradeReturnDTO></returns>
        public async Task<List<GradeReturnDTO>> GetAllGrades()
        {
            #region Declare Return Var with Intial Value
            List<GradeReturnDTO> allGrades = null;
            #endregion
            try
            {
                #region Vars
                List<Grade> GradeList = null;
                #endregion
                GradeList = await UnitOfWork.GradeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (GradeList != null && GradeList.Any())
                {
                    allGrades = GradeMapping.MappingGradeToGradeReturnDTO(GradeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allGrades;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddGrade(GradeAddDTO GradeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isGradeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Grade Grade = null;
                    #endregion
                    Grade = GradeMapping.MappingGradeAddDTOToGrade(GradeAddDTO);
                    if (Grade != null)
                    {
                        await UnitOfWork.GradeRepository.Insert(Grade);
                        isGradeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isGradeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<GradeReturnDTO></returns>
            public async Task<GradeReturnDTO> GetGradeById(int GradeId)
            {
                #region Declare a return type with initial value.
                GradeReturnDTO Grade = new GradeReturnDTO();
                #endregion
                try
                {
                    Grade grade = await UnitOfWork.GradeRepository.GetById((byte)GradeId);
                    if (grade != null)
                    {
                        if (grade.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Grade = GradeMapping.MappingGradeToGradeReturnDTO(grade);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Grade;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateGrade(GradeUpdateDTO GradeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isGradeUpdated = default(bool);
                #endregion
                try
                {
                    if (GradeUpdateDTO != null)
                    {
                        #region Vars
                        Grade Grade = null;
                        #endregion
                        #region Get Activity By Id
                        Grade = await UnitOfWork.GradeRepository.GetById((byte)GradeUpdateDTO.GradeId);
                        #endregion
                        if (Grade != null)
                        {
                            #region  Mapping
                            Grade = GradeMapping.MappingGradeupdateDTOToGrade(Grade ,GradeUpdateDTO);
                            #endregion
                            if (Grade != null)
                            {
                                #region  Update Entity
                                UnitOfWork.GradeRepository.Update(Grade);
                                isGradeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isGradeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteGrade(int GradeId)
            {
                #region Declare a return type with initial value.
                bool isGradeDeleted = default(bool);
                #endregion
                try
                {
                    if (GradeId > default(int))
                    {
                        #region Vars
                        Grade Grade = null;
                        #endregion
                        #region Get Grade by id
                        Grade = await UnitOfWork.GradeRepository.GetById((byte)GradeId);
                        #endregion
                        #region check if object is not null
                        if (Grade != null)
                        {
                            Grade.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.GradeRepository.Update(Grade);
                            isGradeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isGradeDeleted;
            }
#endregion
        }
    }




