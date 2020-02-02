using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostRelatedIndustryDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class PostRelatedIndustryBusinessMapping : BaseBusinessMapping, IPostRelatedIndustryBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IPostRelatedIndustryMapping PostRelatedIndustryMapping { get; }
        #endregion

        #region Constructor
        public PostRelatedIndustryBusinessMapping(IUnitOfWork unitOfWork, IPostRelatedIndustryMapping postRelatedIndustryMapping)
        {
            UnitOfWork = unitOfWork;
            PostRelatedIndustryMapping = postRelatedIndustryMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<PostRelatedIndustryReturnDTO></returns>
        public async Task<List<PostRelatedIndustryReturnDTO>> GetAllPostRelatedIndustrys()
        {
            #region Declare Return Var with Intial Value
            List<PostRelatedIndustryReturnDTO> allPostRelatedIndustrys = null;
            #endregion
            try
            {
                #region Vars
                List<PostRelatedIndustry> PostRelatedIndustryList = null;
                #endregion
                PostRelatedIndustryList = await UnitOfWork.PostRelatedIndustryRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (PostRelatedIndustryList != null && PostRelatedIndustryList.Any())
                {
                    allPostRelatedIndustrys = PostRelatedIndustryMapping.MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(PostRelatedIndustryList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allPostRelatedIndustrys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddPostRelatedIndustry(PostRelatedIndustryAddDTO PostRelatedIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                bool isPostRelatedIndustryCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    PostRelatedIndustry PostRelatedIndustry = null;
                    #endregion
                    PostRelatedIndustry = PostRelatedIndustryMapping.MappingPostRelatedIndustryAddDTOToPostRelatedIndustry(PostRelatedIndustryAddDTO);
                    if (PostRelatedIndustry != null)
                    {
                        await UnitOfWork.PostRelatedIndustryRepository.Insert(PostRelatedIndustry);
                        isPostRelatedIndustryCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostRelatedIndustryCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<PostRelatedIndustryReturnDTO></returns>
            public async Task<PostRelatedIndustryReturnDTO> GetPostRelatedIndustryById(int PostRelatedIndustryId)
            {
                #region Declare a return type with initial value.
                PostRelatedIndustryReturnDTO PostRelatedIndustry = new PostRelatedIndustryReturnDTO();
                #endregion
                try
                {
                    PostRelatedIndustry postRelatedIndustry = await UnitOfWork.PostRelatedIndustryRepository.GetById(PostRelatedIndustryId);
                    if (postRelatedIndustry != null)
                    {
                        if (postRelatedIndustry.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            PostRelatedIndustry = PostRelatedIndustryMapping.MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(postRelatedIndustry);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return PostRelatedIndustry;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdatePostRelatedIndustry(PostRelatedIndustryUpdateDTO PostRelatedIndustryUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isPostRelatedIndustryUpdated = default(bool);
                #endregion
                try
                {
                    if (PostRelatedIndustryUpdateDTO != null)
                    {
                        #region Vars
                        PostRelatedIndustry PostRelatedIndustry = null;
                        #endregion
                        #region Get Activity By Id
                        PostRelatedIndustry = await UnitOfWork.PostRelatedIndustryRepository.GetById(PostRelatedIndustryUpdateDTO.PostRelatedIndustryId);
                        #endregion
                        if (PostRelatedIndustry != null)
                        {
                            #region  Mapping
                            PostRelatedIndustry = PostRelatedIndustryMapping.MappingPostRelatedIndustryupdateDTOToPostRelatedIndustry(PostRelatedIndustry ,PostRelatedIndustryUpdateDTO);
                            #endregion
                            if (PostRelatedIndustry != null)
                            {
                                #region  Update Entity
                                UnitOfWork.PostRelatedIndustryRepository.Update(PostRelatedIndustry);
                                isPostRelatedIndustryUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostRelatedIndustryUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeletePostRelatedIndustry(int PostRelatedIndustryId)
            {
                #region Declare a return type with initial value.
                bool isPostRelatedIndustryDeleted = default(bool);
                #endregion
                try
                {
                    if (PostRelatedIndustryId > default(int))
                    {
                        #region Vars
                        PostRelatedIndustry PostRelatedIndustry = null;
                        #endregion
                        #region Get PostRelatedIndustry by id
                        PostRelatedIndustry = await UnitOfWork.PostRelatedIndustryRepository.GetById(PostRelatedIndustryId);
                        #endregion
                        #region check if object is not null
                        if (PostRelatedIndustry != null)
                        {
                            PostRelatedIndustry.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.PostRelatedIndustryRepository.Update(PostRelatedIndustry);
                            isPostRelatedIndustryDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isPostRelatedIndustryDeleted;
            }
#endregion
        }
    }




