using IPMATS.Common.Auth;
using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.AdminDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class AdminBusinessMapping : BaseBusinessMapping, IAdminBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IAdminMapping AdminMapping { get; }
        #endregion

        #region Constructor
        public AdminBusinessMapping(IUnitOfWork unitOfWork, IAdminMapping adminMapping)
        {
            UnitOfWork = unitOfWork;
            AdminMapping = adminMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<AdminReturnDTO></returns>
        public async Task<List<AdminReturnDTO>> GetAllAdmins()
        {
            #region Declare Return Var with Intial Value
            List<AdminReturnDTO> allAdmins = null;
            #endregion
            try
            {
                #region Vars
                List<Admin> AdminList = null;
                #endregion
                AdminList = await UnitOfWork.AdminRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (AdminList != null && AdminList.Any())
                {
                    allAdmins = AdminMapping.MappingAdminToAdminReturnDTO(AdminList);
                }
            }
            catch (Exception exception)
            {

            }
            return allAdmins;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddAdmin(AdminAddDTO AdminAddDTO)
        {
            #region Declare a return type with initial value.
            bool isAdminCreated = default(bool);
            #endregion
            try
            {
                #region Vars
                Admin Admin = null;
                #endregion
                Admin = AdminMapping.MappingAdminAddDTOToAdmin(AdminAddDTO);
                if (Admin != null)
                {
                    await UnitOfWork.AdminRepository.Insert(Admin);
                    isAdminCreated = await UnitOfWork.Commit() > default(int);
                }
            }
            catch (Exception exception)
            {

            }
            return isAdminCreated;
        }
        /// <summary>
        /// Get user Action Activity Log By Id
        /// </summary>
        /// <returns>List<AdminReturnDTO></returns>
        public async Task<AdminReturnDTO> GetAdminById(int AdminId)
        {
            #region Declare a return type with initial value.
            AdminReturnDTO Admin = new AdminReturnDTO();
            #endregion
            try
            {
                Admin admin = await UnitOfWork.AdminRepository.GetById(AdminId);
                if (admin != null)
                {
                    if (admin.IsDeleted != (byte)DeleteStatusEnum.Deleted)
                        Admin = AdminMapping.MappingAdminToAdminReturnDTO(admin);
                }
            }
            catch (Exception exception)
            {

            }
            return Admin;
        }
        /// <summary>
        /// Update User Action Activity Log 
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> UpdateAdmin(AdminUpdateDTO AdminUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isAdminUpdated = default(bool);
            #endregion
            try
            {
                if (AdminUpdateDTO != null)
                {
                    #region Vars
                    Admin Admin = null;
                    #endregion
                    #region Get Activity By Id
                    Admin = await UnitOfWork.AdminRepository.GetById(AdminUpdateDTO.AdminId);
                    #endregion
                    if (Admin != null)
                    {
                        #region  Mapping
                        Admin = AdminMapping.MappingAdminupdateDTOToAdmin(Admin, AdminUpdateDTO);
                        #endregion
                        if (Admin != null)
                        {
                            #region  Update Entity
                            UnitOfWork.AdminRepository.Update(Admin);
                            isAdminUpdated = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                    }
                }
            }
            catch (Exception exception)
            {

            }
            return isAdminUpdated;
        }
        /// <summary>
        /// Delete User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteAdmin(int AdminId)
        {
            #region Declare a return type with initial value.
            bool isAdminDeleted = default(bool);
            #endregion
            try
            {
                if (AdminId > default(int))
                {
                    #region Vars
                    Admin Admin = null;
                    #endregion
                    #region Get Admin by id
                    Admin = await UnitOfWork.AdminRepository.GetById(AdminId);
                    #endregion
                    #region check if object is not null
                    if (Admin != null)
                    {
                        Admin.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                        #region Apply the changes to the database
                        UnitOfWork.AdminRepository.Update(Admin);
                        isAdminDeleted = await UnitOfWork.Commit() > default(int);
                        #endregion
                    }
                    #endregion
                }
            }
            catch (Exception exception)
            {

            }
            return isAdminDeleted;
        }
        /// <summary>
        ///Admin Login Async
        /// </summary>
        /// <param name="AdminLoginDTO"></param>
        /// <returns>bool</returns>
        public async Task<UserDTO> AdminLoginAsync(UserLoginDTO adminLoginDTO)
        {
            #region Declare a return type with initial value.
            UserDTO AdminReturn = new UserDTO();
            #endregion
            try
            {
                Admin admin = null;
                if (adminLoginDTO != null)
                {
                    admin = await UnitOfWork.AdminRepository.GetWhere(x => x.FullName.Trim().ToLower().Equals(adminLoginDTO.Email.Trim().ToLower())
                                                                       && x.IsDeleted == (byte)DeleteStatusEnum.NotDeleted).FirstOrDefaultAsync();
                    if (admin != null)
                    {
                        if (VerifyPasswordHash(adminLoginDTO.Password, admin.PasswordHash, admin.PasswordSalt))
                            AdminReturn = AdminMapping.MappingAdminToUserDTO(admin);
                        AdminReturn.Token = TokenHandler.CreateToken(AdminReturn);
                    }
                }
            }
            catch (Exception exception)
            {
               // Logger.Instance.LogException(exception, LogLevel.Medium);
            }
            return AdminReturn;
        }
        /// <summary>
        ///User Verify PasswordHash
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            bool IsVerifyed = default(bool);
            try
            {
                //TODO:@AbdelRahman
                //Avoid Multiple Return
                using (var hmac = new System.Security.Cryptography.HMACMD5(passwordSalt))
                {
                    var CoumputedHash = hmac.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
                    IsVerifyed = true;
                    for (int i = 0; i < CoumputedHash.Length; i++)
                    {
                        if (CoumputedHash[i] != passwordHash[i])
                            IsVerifyed = false;
                    }
                }
            }
            catch (Exception exception)
            {
                //Logger.Instance.LogException(exception, LogLevel.Medium);
                IsVerifyed = false;
            }
            return IsVerifyed;
        }
        #endregion
    }
}




