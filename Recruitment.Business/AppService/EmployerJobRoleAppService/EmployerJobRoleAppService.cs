using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.EmployerJobRoleDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class EmployerJobRoleAppService : BaseAppService, IEmployerJobRoleAppService
    {
        #region Properties
        public IEmployerJobRoleBusinessMapping EmployerJobRoleBusinessMapping { get; }
        #endregion

        #region Constructor
        public EmployerJobRoleAppService(IEmployerJobRoleBusinessMapping employerJobRoleBusinessMapping)
        {
            EmployerJobRoleBusinessMapping = employerJobRoleBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All EmployerJobRole ActionActivity Logs for All EmployerJobRoles
        /// </summary>
        /// <returns>List<EmployerJobRoleReturnDTO></returns>
        public async Task<List<EmployerJobRoleReturnDTO>> GetAllEmployerJobRoles()
        {
            #region Declare a return type with initial value.
            List<EmployerJobRoleReturnDTO> allEmployerJobRoles = null;
            #endregion
            try
            {
                allEmployerJobRoles = await EmployerJobRoleBusinessMapping.GetAllEmployerJobRoles();
            }
            catch (Exception exception)  {}
            return allEmployerJobRoles;
        }
        /// <summary>
        /// Add EmployerJobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddEmployerJobRole(EmployerJobRoleAddDTO employerJobRoleAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (employerJobRoleAddDTO != null)
                {
                    isCreated = await EmployerJobRoleBusinessMapping.AddEmployerJobRole(employerJobRoleAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  EmployerJobRole By Id 
        /// </summary>
        /// <returns>EmployerJobRoleReturnDTO<EmployerJobRoleReturnDTO></returns>
        public async Task<EmployerJobRoleReturnDTO> GetEmployerJobRoleById(int EmployerJobRoleId)
        {
            #region Declare a return type with initial value.
            EmployerJobRoleReturnDTO EmployerJobRole = null;
            #endregion
            try
            {
                if (EmployerJobRoleId > default(int))
                {
                    EmployerJobRole = await EmployerJobRoleBusinessMapping.GetEmployerJobRoleById(EmployerJobRoleId);
                }
            }
            catch (Exception exception)  {}
            return EmployerJobRole;
        }
        /// <summary>
        /// Updae EmployerJobRole AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateEmployerJobRole(EmployerJobRoleUpdateDTO employerJobRoleUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (employerJobRoleUpdateDTO != null)
                {
                    isUpdated = await EmployerJobRoleBusinessMapping.UpdateEmployerJobRole(employerJobRoleUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete EmployerJobRole AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteEmployerJobRole(int EmployerJobRoleId)
        {
            bool isDeleted = false;
            try
            {
                if (EmployerJobRoleId > default(int))
                {
                    isDeleted = await EmployerJobRoleBusinessMapping.DeleteEmployerJobRole(EmployerJobRoleId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




