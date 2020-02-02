using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class PostBusinessMapping : BaseBusinessMapping, IPostBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IPostMapping PostMapping { get; }
        #endregion

        #region Constructor
        public PostBusinessMapping(IUnitOfWork unitOfWork, IPostMapping postMapping)
        {
            UnitOfWork = unitOfWork;
            PostMapping = postMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<PostReturnDTO></returns>
        public async Task<List<PostReturnDTO>> GetAllPosts()
        {
            #region Declare Return Var with Intial Value
            List<PostReturnDTO> allPosts = null;
            #endregion
            try
            {
                #region Vars
                List<Post> PostList = null;
                #endregion
                PostList = await UnitOfWork.PostRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (PostList != null && PostList.Any())
                {
                    allPosts = PostMapping.MappingPostToPostReturnDTO(PostList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allPosts;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddPost(PostAddDTO PostAddDTO)
            {
                #region Declare a return type with initial value.
                bool isPostCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Post Post = null;
                    #endregion
                    Post = PostMapping.MappingPostAddDTOToPost(PostAddDTO);
                    if (Post != null)
                    {
                        await UnitOfWork.PostRepository.Insert(Post);
                        isPostCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<PostReturnDTO></returns>
            public async Task<PostReturnDTO> GetPostById(int PostId)
            {
                #region Declare a return type with initial value.
                PostReturnDTO Post = new PostReturnDTO();
                #endregion
                try
                {
                    Post post = await UnitOfWork.PostRepository.GetById(PostId);
                    if (post != null)
                    {
                        if (post.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Post = PostMapping.MappingPostToPostReturnDTO(post);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Post;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdatePost(PostUpdateDTO PostUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isPostUpdated = default(bool);
                #endregion
                try
                {
                    if (PostUpdateDTO != null)
                    {
                        #region Vars
                        Post Post = null;
                        #endregion
                        #region Get Activity By Id
                        Post = await UnitOfWork.PostRepository.GetById(PostUpdateDTO.PostId);
                        #endregion
                        if (Post != null)
                        {
                            #region  Mapping
                            Post = PostMapping.MappingPostupdateDTOToPost(Post ,PostUpdateDTO);
                            #endregion
                            if (Post != null)
                            {
                                #region  Update Entity
                                UnitOfWork.PostRepository.Update(Post);
                                isPostUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeletePost(int PostId)
            {
                #region Declare a return type with initial value.
                bool isPostDeleted = default(bool);
                #endregion
                try
                {
                    if (PostId > default(int))
                    {
                        #region Vars
                        Post Post = null;
                        #endregion
                        #region Get Post by id
                        Post = await UnitOfWork.PostRepository.GetById(PostId);
                        #endregion
                        #region check if object is not null
                        if (Post != null)
                        {
                            Post.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.PostRepository.Update(Post);
                            isPostDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostDeleted;
            }
#endregion
        }
    }




