using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostTypeDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class PostTypeBusinessMapping : BaseBusinessMapping, IPostTypeBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IPostTypeMapping PostTypeMapping { get; }
        #endregion

        #region Constructor
        public PostTypeBusinessMapping(IUnitOfWork unitOfWork, IPostTypeMapping postTypeMapping)
        {
            UnitOfWork = unitOfWork;
            PostTypeMapping = postTypeMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<PostTypeReturnDTO></returns>
        public async Task<List<PostTypeReturnDTO>> GetAllPostTypes()
        {
            #region Declare Return Var with Intial Value
            List<PostTypeReturnDTO> allPostTypes = null;
            #endregion
            try
            {
                #region Vars
                List<PostType> PostTypeList = null;
                #endregion
                PostTypeList = await UnitOfWork.PostTypeRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (PostTypeList != null && PostTypeList.Any())
                {
                    allPostTypes = PostTypeMapping.MappingPostTypeToPostTypeReturnDTO(PostTypeList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allPostTypes;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddPostType(PostTypeAddDTO PostTypeAddDTO)
            {
                #region Declare a return type with initial value.
                bool isPostTypeCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    PostType PostType = null;
                    #endregion
                    PostType = PostTypeMapping.MappingPostTypeAddDTOToPostType(PostTypeAddDTO);
                    if (PostType != null)
                    {
                        await UnitOfWork.PostTypeRepository.Insert(PostType);
                        isPostTypeCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostTypeCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<PostTypeReturnDTO></returns>
            public async Task<PostTypeReturnDTO> GetPostTypeById(int PostTypeId)
            {
                #region Declare a return type with initial value.
                PostTypeReturnDTO PostType = new PostTypeReturnDTO();
                #endregion
                try
                {
                    PostType postType = await UnitOfWork.PostTypeRepository.GetById(PostTypeId);
                    if (postType != null)
                    {
                        if (postType.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            PostType = PostTypeMapping.MappingPostTypeToPostTypeReturnDTO(postType);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return PostType;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdatePostType(PostTypeUpdateDTO PostTypeUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isPostTypeUpdated = default(bool);
                #endregion
                try
                {
                    if (PostTypeUpdateDTO != null)
                    {
                        #region Vars
                        PostType PostType = null;
                        #endregion
                        #region Get Activity By Id
                        PostType = await UnitOfWork.PostTypeRepository.GetById(PostTypeUpdateDTO.PostTypeId);
                        #endregion
                        if (PostType != null)
                        {
                            #region  Mapping
                            PostType = PostTypeMapping.MappingPostTypeupdateDTOToPostType(PostType ,PostTypeUpdateDTO);
                            #endregion
                            if (PostType != null)
                            {
                                #region  Update Entity
                                UnitOfWork.PostTypeRepository.Update(PostType);
                                isPostTypeUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostTypeUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeletePostType(int PostTypeId)
            {
                #region Declare a return type with initial value.
                bool isPostTypeDeleted = default(bool);
                #endregion
                try
                {
                    if (PostTypeId > default(int))
                    {
                        #region Vars
                        PostType PostType = null;
                        #endregion
                        #region Get PostType by id
                        PostType = await UnitOfWork.PostTypeRepository.GetById(PostTypeId);
                        #endregion
                        #region check if object is not null
                        if (PostType != null)
                        {
                            PostType.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.PostTypeRepository.Update(PostType);
                            isPostTypeDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostTypeDeleted;
            }
#endregion
        }
    }




