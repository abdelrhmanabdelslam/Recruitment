using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.CareerLevelDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class CareerLevelAppService : BaseAppService, ICareerLevelAppService
    {
        #region Properties
        public ICareerLevelBusinessMapping CareerLevelBusinessMapping { get; }
        #endregion

        #region Constructor
        public CareerLevelAppService(ICareerLevelBusinessMapping careerLevelBusinessMapping)
        {
            CareerLevelBusinessMapping = careerLevelBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All CareerLevel ActionActivity Logs for All CareerLevels
        /// </summary>
        /// <returns>List<CareerLevelReturnDTO></returns>
        public async Task<List<CareerLevelReturnDTO>> GetAllCareerLevels()
        {
            #region Declare a return type with initial value.
            List<CareerLevelReturnDTO> allCareerLevels = null;
            #endregion
            try
            {
                allCareerLevels = await CareerLevelBusinessMapping.GetAllCareerLevels();
            }
            catch (Exception exception)  {}
            return allCareerLevels;
        }
        /// <summary>
        /// Add CareerLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddCareerLevel(CareerLevelAddDTO careerLevelAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (careerLevelAddDTO != null)
                {
                    isCreated = await CareerLevelBusinessMapping.AddCareerLevel(careerLevelAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  CareerLevel By Id 
        /// </summary>
        /// <returns>CareerLevelReturnDTO<CareerLevelReturnDTO></returns>
        public async Task<CareerLevelReturnDTO> GetCareerLevelById(int CareerLevelId)
        {
            #region Declare a return type with initial value.
            CareerLevelReturnDTO CareerLevel = null;
            #endregion
            try
            {
                if (CareerLevelId > default(int))
                {
                    CareerLevel = await CareerLevelBusinessMapping.GetCareerLevelById(CareerLevelId);
                }
            }
            catch (Exception exception)  {}
            return CareerLevel;
        }
        /// <summary>
        /// Updae CareerLevel AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateCareerLevel(CareerLevelUpdateDTO careerLevelUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (careerLevelUpdateDTO != null)
                {
                    isUpdated = await CareerLevelBusinessMapping.UpdateCareerLevel(careerLevelUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete CareerLevel AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteCareerLevel(int CareerLevelId)
        {
            bool isDeleted = false;
            try
            {
                if (CareerLevelId > default(int))
                {
                    isDeleted = await CareerLevelBusinessMapping.DeleteCareerLevel(CareerLevelId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




