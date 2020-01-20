using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.EmployerDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class EmployerAppService : BaseAppService, IEmployerAppService
    {
        #region Properties
        public IEmployerBusinessMapping EmployerBusinessMapping { get; }
        #endregion

        #region Constructor
        public EmployerAppService(IEmployerBusinessMapping employerBusinessMapping)
        {
            EmployerBusinessMapping = employerBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Employer ActionActivity Logs for All Employers
        /// </summary>
        /// <returns>List<EmployerReturnDTO></returns>
        public async Task<List<EmployerReturnDTO>> GetAllEmployers()
        {
            #region Declare a return type with initial value.
            List<EmployerReturnDTO> allEmployers = null;
            #endregion
            try
            {
                allEmployers = await EmployerBusinessMapping.GetAllEmployers();
            }
            catch (Exception exception)  {}
            return allEmployers;
        }
        /// <summary>
        /// Add Employer AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddEmployer(EmployerAddDTO employerAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (employerAddDTO != null)
                {
                    isCreated = await EmployerBusinessMapping.AddEmployer(employerAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Employer By Id 
        /// </summary>
        /// <returns>EmployerReturnDTO<EmployerReturnDTO></returns>
        public async Task<EmployerReturnDTO> GetEmployerById(int EmployerId)
        {
            #region Declare a return type with initial value.
            EmployerReturnDTO Employer = null;
            #endregion
            try
            {
                if (EmployerId > default(int))
                {
                    Employer = await EmployerBusinessMapping.GetEmployerById(EmployerId);
                }
            }
            catch (Exception exception)  {}
            return Employer;
        }
        /// <summary>
        /// Updae Employer AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateEmployer(EmployerUpdateDTO employerUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (employerUpdateDTO != null)
                {
                    isUpdated = await EmployerBusinessMapping.UpdateEmployer(employerUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Employer AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteEmployer(int EmployerId)
        {
            bool isDeleted = false;
            try
            {
                if (EmployerId > default(int))
                {
                    isDeleted = await EmployerBusinessMapping.DeleteEmployer(EmployerId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




