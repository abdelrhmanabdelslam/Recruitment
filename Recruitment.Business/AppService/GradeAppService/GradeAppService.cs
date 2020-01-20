using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.GradeDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class GradeAppService : BaseAppService, IGradeAppService
    {
        #region Properties
        public IGradeBusinessMapping GradeBusinessMapping { get; }
        #endregion

        #region Constructor
        public GradeAppService(IGradeBusinessMapping gradeBusinessMapping)
        {
            GradeBusinessMapping = gradeBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Grade ActionActivity Logs for All Grades
        /// </summary>
        /// <returns>List<GradeReturnDTO></returns>
        public async Task<List<GradeReturnDTO>> GetAllGrades()
        {
            #region Declare a return type with initial value.
            List<GradeReturnDTO> allGrades = null;
            #endregion
            try
            {
                allGrades = await GradeBusinessMapping.GetAllGrades();
            }
            catch (Exception exception)  {}
            return allGrades;
        }
        /// <summary>
        /// Add Grade AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddGrade(GradeAddDTO gradeAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (gradeAddDTO != null)
                {
                    isCreated = await GradeBusinessMapping.AddGrade(gradeAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Grade By Id 
        /// </summary>
        /// <returns>GradeReturnDTO<GradeReturnDTO></returns>
        public async Task<GradeReturnDTO> GetGradeById(int GradeId)
        {
            #region Declare a return type with initial value.
            GradeReturnDTO Grade = null;
            #endregion
            try
            {
                if (GradeId > default(int))
                {
                    Grade = await GradeBusinessMapping.GetGradeById(GradeId);
                }
            }
            catch (Exception exception)  {}
            return Grade;
        }
        /// <summary>
        /// Updae Grade AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateGrade(GradeUpdateDTO gradeUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (gradeUpdateDTO != null)
                {
                    isUpdated = await GradeBusinessMapping.UpdateGrade(gradeUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Grade AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteGrade(int GradeId)
        {
            bool isDeleted = false;
            try
            {
                if (GradeId > default(int))
                {
                    isDeleted = await GradeBusinessMapping.DeleteGrade(GradeId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




