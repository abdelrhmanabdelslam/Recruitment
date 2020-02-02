using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostIndustryDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class PostIndustryBusinessMapping : BaseBusinessMapping, IPostIndustryBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IPostIndustryMapping PostIndustryMapping { get; }
        #endregion

        #region Constructor
        public PostIndustryBusinessMapping(IUnitOfWork unitOfWork, IPostIndustryMapping postIndustryMapping)
        {
            UnitOfWork = unitOfWork;
            PostIndustryMapping = postIndustryMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<PostIndustryReturnDTO></returns>
        public async Task<List<PostIndustryReturnDTO>> GetAllPostIndustrys()
        {
            #region Declare Return Var with Intial Value
            List<PostIndustryReturnDTO> allPostIndustrys = null;
            #endregion
            try
            {
                #region Vars
                List<PostIndustry> PostIndustryList = null;
                #endregion
                PostIndustryList = await UnitOfWork.PostIndustryRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (PostIndustryList != null && PostIndustryList.Any())
                {
                    allPostIndustrys = PostIndustryMapping.MappingPostIndustryToPostIndustryReturnDTO(PostIndustryList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allPostIndustrys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddPostIndustry(PostIndustryAddDTO PostIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                bool isPostIndustryCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    PostIndustry PostIndustry = null;
                    #endregion
                    PostIndustry = PostIndustryMapping.MappingPostIndustryAddDTOToPostIndustry(PostIndustryAddDTO);
                    if (PostIndustry != null)
                    {
                        await UnitOfWork.PostIndustryRepository.Insert(PostIndustry);
                        isPostIndustryCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostIndustryCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<PostIndustryReturnDTO></returns>
            public async Task<PostIndustryReturnDTO> GetPostIndustryById(int PostIndustryId)
            {
                #region Declare a return type with initial value.
                PostIndustryReturnDTO PostIndustry = new PostIndustryReturnDTO();
                #endregion
                try
                {
                    PostIndustry postIndustry = await UnitOfWork.PostIndustryRepository.GetById(PostIndustryId);
                    if (postIndustry != null)
                    {
                        if (postIndustry.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            PostIndustry = PostIndustryMapping.MappingPostIndustryToPostIndustryReturnDTO(postIndustry);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return PostIndustry;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdatePostIndustry(PostIndustryUpdateDTO PostIndustryUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isPostIndustryUpdated = default(bool);
                #endregion
                try
                {
                    if (PostIndustryUpdateDTO != null)
                    {
                        #region Vars
                        PostIndustry PostIndustry = null;
                        #endregion
                        #region Get Activity By Id
                        PostIndustry = await UnitOfWork.PostIndustryRepository.GetById(PostIndustryUpdateDTO.PostIndustryId);
                        #endregion
                        if (PostIndustry != null)
                        {
                            #region  Mapping
                            PostIndustry = PostIndustryMapping.MappingPostIndustryupdateDTOToPostIndustry(PostIndustry ,PostIndustryUpdateDTO);
                            #endregion
                            if (PostIndustry != null)
                            {
                                #region  Update Entity
                                UnitOfWork.PostIndustryRepository.Update(PostIndustry);
                                isPostIndustryUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostIndustryUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeletePostIndustry(int PostIndustryId)
            {
                #region Declare a return type with initial value.
                bool isPostIndustryDeleted = default(bool);
                #endregion
                try
                {
                    if (PostIndustryId > default(int))
                    {
                        #region Vars
                        PostIndustry PostIndustry = null;
                        #endregion
                        #region Get PostIndustry by id
                        PostIndustry = await UnitOfWork.PostIndustryRepository.GetById(PostIndustryId);
                        #endregion
                        #region check if object is not null
                        if (PostIndustry != null)
                        {
                            PostIndustry.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.PostIndustryRepository.Update(PostIndustry);
                            isPostIndustryDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostIndustryDeleted;
            }
#endregion
        }
    }




