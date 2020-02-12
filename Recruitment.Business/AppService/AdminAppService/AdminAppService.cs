using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.AdminDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class AdminAppService : BaseAppService, IAdminAppService
    {
        #region Properties
        public IAdminBusinessMapping AdminBusinessMapping { get; }
        #endregion

        #region Constructor
        public AdminAppService(IAdminBusinessMapping adminBusinessMapping)
        {
            AdminBusinessMapping = adminBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Admin ActionActivity Logs for All Admins
        /// </summary>
        /// <returns>List<AdminReturnDTO></returns>
        public async Task<List<AdminReturnDTO>> GetAllAdmins()
        {
            #region Declare a return type with initial value.
            List<AdminReturnDTO> allAdmins = null;
            #endregion
            try
            {
                allAdmins = await AdminBusinessMapping.GetAllAdmins();
            }
            catch (Exception exception)  {}
            return allAdmins;
        }
        /// <summary>
        /// Add Admin AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddAdmin(AdminAddDTO adminAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (adminAddDTO != null)
                {
                    isCreated = await AdminBusinessMapping.AddAdmin(adminAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Admin By Id 
        /// </summary>
        /// <returns>AdminReturnDTO<AdminReturnDTO></returns>
        public async Task<AdminReturnDTO> GetAdminById(int AdminId)
        {
            #region Declare a return type with initial value.
            AdminReturnDTO Admin = null;
            #endregion
            try
            {
                if (AdminId > default(int))
                {
                    Admin = await AdminBusinessMapping.GetAdminById(AdminId);
                }
            }
            catch (Exception exception)  {}
            return Admin;
        }
        /// <summary>
        /// Updae Admin AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateAdmin(AdminUpdateDTO adminUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (adminUpdateDTO != null)
                {
                    isUpdated = await AdminBusinessMapping.UpdateAdmin(adminUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Admin AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteAdmin(int AdminId)
        {
            bool isDeleted = false;
            try
            {
                if (AdminId > default(int))
                {
                    isDeleted = await AdminBusinessMapping.DeleteAdmin(AdminId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}




