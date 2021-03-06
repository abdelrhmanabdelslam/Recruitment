using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.AdminDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;
using IPMATS.Common.Auth;
using Recruitment.DTOS.EmployerDTOS;

namespace Recruitment.Mapping.Mapping
{
    public class AdminMapping : IDisposable, IAdminMapping
    {
        public List<AdminReturnDTO> MappingAdminToAdminReturnDTO(List<Admin> AdminList)
        {

            List<AdminReturnDTO> AdminReturnDTOList = null;
            try
            {
                if (AdminList.Any() && AdminList != null)
                {
                    AdminReturnDTOList = AdminList.Select(u => new AdminReturnDTO
                    {
                        AdminId = u.AdminId,
                        FullName = u.FullName
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return AdminReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Admin></returns>
        public Admin MappingAdminAddDTOToAdmin(AdminAddDTO AdminAddDTO, UserPasswordDTO userPasswordDTO)
        {
                #region Declare a return type with initial value.
                Admin Admin = null;
                #endregion
                try
                {
                    Admin = new Admin
                    {
                        FullName = AdminAddDTO.FullName,
                        Address = AdminAddDTO.Address,
                        Phone = AdminAddDTO.Phone,
                        Email = AdminAddDTO.Email,
                        PasswordHash = userPasswordDTO.PasswordHash,
                        PasswordSalt = userPasswordDTO.PasswordSalt,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Admin;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Admin MappingAdminupdateDTOToAdmin(Admin admin, AdminUpdateDTO AdminUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Admin Admin = admin;
                #endregion
                try
                {
                    if (AdminUpdateDTO.AdminId > default(int))
                    {
                        Admin.AdminId = AdminUpdateDTO.AdminId;
                        Admin.FullName  = AdminUpdateDTO.FullName;
                    }
                }
                catch (Exception exception) { }
                return Admin;
            }
            public AdminReturnDTO MappingAdminToAdminReturnDTO(Admin Admin)
            {
                #region Declare a return type with initial value.
                AdminReturnDTO AdminReturnDTO = null;
                #endregion
                try
                {
                    if (Admin != null)
                    {
                        AdminReturnDTO = new AdminReturnDTO
                        {
                            AdminId = Admin.AdminId,
                            FullName = Admin.FullName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return AdminReturnDTO;
            }
        public UserDTO MappingAdminToUserDTO(Admin Admin)
        {
            #region Declare a return type with initial value.
            UserDTO userDTO = null;
                #endregion
                try
                {
                    if (Admin != null)
                    {
                        userDTO = new UserDTO
                        {
                            UserId =  Admin.AdminId,
                            Email = Admin.Email,
                            UserName = Admin.FullName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return userDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




