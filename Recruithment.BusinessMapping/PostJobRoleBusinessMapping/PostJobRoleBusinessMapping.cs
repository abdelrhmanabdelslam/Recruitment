using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostJobRoleDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class PostJobRoleBusinessMapping : BaseBusinessMapping, IPostJobRoleBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IPostJobRoleMapping PostJobRoleMapping { get; }
        #endregion

        #region Constructor
        public PostJobRoleBusinessMapping(IUnitOfWork unitOfWork, IPostJobRoleMapping postJobRoleMapping)
        {
            UnitOfWork = unitOfWork;
            PostJobRoleMapping = postJobRoleMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<PostJobRoleReturnDTO></returns>
        public async Task<List<PostJobRoleReturnDTO>> GetAllPostJobRoles()
        {
            #region Declare Return Var with Intial Value
            List<PostJobRoleReturnDTO> allPostJobRoles = null;
            #endregion
            try
            {
                #region Vars
                List<PostJobRole> PostJobRoleList = null;
                #endregion
                PostJobRoleList = await UnitOfWork.PostJobRoleRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (PostJobRoleList != null && PostJobRoleList.Any())
                {
                    allPostJobRoles = PostJobRoleMapping.MappingPostJobRoleToPostJobRoleReturnDTO(PostJobRoleList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allPostJobRoles;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddPostJobRole(PostJobRoleAddDTO PostJobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                bool isPostJobRoleCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    PostJobRole PostJobRole = null;
                    #endregion
                    PostJobRole = PostJobRoleMapping.MappingPostJobRoleAddDTOToPostJobRole(PostJobRoleAddDTO);
                    if (PostJobRole != null)
                    {
                        await UnitOfWork.PostJobRoleRepository.Insert(PostJobRole);
                        isPostJobRoleCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostJobRoleCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<PostJobRoleReturnDTO></returns>
            public async Task<PostJobRoleReturnDTO> GetPostJobRoleById(int PostJobRoleId)
            {
                #region Declare a return type with initial value.
                PostJobRoleReturnDTO PostJobRole = new PostJobRoleReturnDTO();
                #endregion
                try
                {
                    PostJobRole postJobRole = await UnitOfWork.PostJobRoleRepository.GetById(PostJobRoleId);
                    if (postJobRole != null)
                    {
                        if (postJobRole.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            PostJobRole = PostJobRoleMapping.MappingPostJobRoleToPostJobRoleReturnDTO(postJobRole);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return PostJobRole;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdatePostJobRole(PostJobRoleUpdateDTO PostJobRoleUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isPostJobRoleUpdated = default(bool);
                #endregion
                try
                {
                    if (PostJobRoleUpdateDTO != null)
                    {
                        #region Vars
                        PostJobRole PostJobRole = null;
                        #endregion
                        #region Get Activity By Id
                        PostJobRole = await UnitOfWork.PostJobRoleRepository.GetById(PostJobRoleUpdateDTO.PostJobRoleId);
                        #endregion
                        if (PostJobRole != null)
                        {
                            #region  Mapping
                            PostJobRole = PostJobRoleMapping.MappingPostJobRoleupdateDTOToPostJobRole(PostJobRole ,PostJobRoleUpdateDTO);
                            #endregion
                            if (PostJobRole != null)
                            {
                                #region  Update Entity
                                UnitOfWork.PostJobRoleRepository.Update(PostJobRole);
                                isPostJobRoleUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostJobRoleUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeletePostJobRole(int PostJobRoleId)
            {
                #region Declare a return type with initial value.
                bool isPostJobRoleDeleted = default(bool);
                #endregion
                try
                {
                    if (PostJobRoleId > default(int))
                    {
                        #region Vars
                        PostJobRole PostJobRole = null;
                        #endregion
                        #region Get PostJobRole by id
                        PostJobRole = await UnitOfWork.PostJobRoleRepository.GetById(PostJobRoleId);
                        #endregion
                        #region check if object is not null
                        if (PostJobRole != null)
                        {
                            PostJobRole.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.PostJobRoleRepository.Update(PostJobRole);
                            isPostJobRoleDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostJobRoleDeleted;
            }
#endregion
        }
    }




