using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.TypeOfJobDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class TypeOfJobAppService : BaseAppService, ITypeOfJobAppService
    {
        #region Properties
        public ITypeOfJobBusinessMapping TypeOfJobBusinessMapping { get; }
        #endregion

        #region Constructor
        public TypeOfJobAppService(ITypeOfJobBusinessMapping typeOfJobBusinessMapping)
        {
            TypeOfJobBusinessMapping = typeOfJobBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All TypeOfJob ActionActivity Logs for All TypeOfJobs
        /// </summary>
        /// <returns>List<TypeOfJobReturnDTO></returns>
        public async Task<List<TypeOfJobReturnDTO>> GetAllTypeOfJobs()
        {
            #region Declare a return type with initial value.
            List<TypeOfJobReturnDTO> allTypeOfJobs = null;
            #endregion
            try
            {
                allTypeOfJobs = await TypeOfJobBusinessMapping.GetAllTypeOfJobs();
            }
            catch (Exception exception)  {}
            return allTypeOfJobs;
        }
        /// <summary>
        /// Add TypeOfJob AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddTypeOfJob(TypeOfJobAddDTO typeOfJobAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (typeOfJobAddDTO != null)
                {
                    isCreated = await TypeOfJobBusinessMapping.AddTypeOfJob(typeOfJobAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  TypeOfJob By Id 
        /// </summary>
        /// <returns>TypeOfJobReturnDTO<TypeOfJobReturnDTO></returns>
        public async Task<TypeOfJobReturnDTO> GetTypeOfJobById(int TypeOfJobId)
        {
            #region Declare a return type with initial value.
            TypeOfJobReturnDTO TypeOfJob = null;
            #endregion
            try
            {
                if (TypeOfJobId > default(int))
                {
                    TypeOfJob = await TypeOfJobBusinessMapping.GetTypeOfJobById(TypeOfJobId);
                }
            }
            catch (Exception exception)  {}
            return TypeOfJob;
        }
        /// <summary>
        /// Updae TypeOfJob AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateTypeOfJob(TypeOfJobUpdateDTO typeOfJobUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (typeOfJobUpdateDTO != null)
                {
                    isUpdated = await TypeOfJobBusinessMapping.UpdateTypeOfJob(typeOfJobUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete TypeOfJob AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteTypeOfJob(int TypeOfJobId)
        {
            bool isDeleted = false;
            try
            {
                if (TypeOfJobId > default(int))
                {
                    isDeleted = await TypeOfJobBusinessMapping.DeleteTypeOfJob(TypeOfJobId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




