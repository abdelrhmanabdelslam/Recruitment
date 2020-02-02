using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostIndustryDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class PostIndustryMapping : IDisposable, IPostIndustryMapping
    {
        public List<PostIndustryReturnDTO> MappingPostIndustryToPostIndustryReturnDTO(List<PostIndustry> PostIndustryList)
        {

            List<PostIndustryReturnDTO> PostIndustryReturnDTOList = null;
            try
            {
                if (PostIndustryList.Any() && PostIndustryList != null)
                {
                    PostIndustryReturnDTOList = PostIndustryList.Select(u => new PostIndustryReturnDTO
                    {
                        IndustryId =  u.IndustryId,
                        PostId = u.PostId,
                        PostIndustryId = u.PostIndustryId
                            
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return PostIndustryReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<PostIndustry></returns>
        public PostIndustry MappingPostIndustryAddDTOToPostIndustry(PostIndustryAddDTO PostIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                PostIndustry PostIndustry = null;
                #endregion
                try
                {
                    PostIndustry = new PostIndustry
                    {
                        IndustryId = PostIndustryAddDTO.IndustryId,
                        PostId = PostIndustryAddDTO.PostId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return PostIndustry;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public PostIndustry MappingPostIndustryupdateDTOToPostIndustry(PostIndustry postIndustry, PostIndustryUpdateDTO PostIndustryUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                PostIndustry PostIndustry = postIndustry;
                #endregion
                try
                {
                    if (PostIndustryUpdateDTO.PostIndustryId > default(int))
                    {
                        PostIndustry.IndustryId = PostIndustryUpdateDTO.IndustryId;
                        PostIndustry.PostId = PostIndustryUpdateDTO.PostId;
                        PostIndustry.PostIndustryId = PostIndustryUpdateDTO.PostIndustryId;
                    }
                }
                catch (Exception exception) { }
                return PostIndustry;
            }
            public PostIndustryReturnDTO MappingPostIndustryToPostIndustryReturnDTO(PostIndustry PostIndustry)
            {
                #region Declare a return type with initial value.
                PostIndustryReturnDTO PostIndustryReturnDTO = null;
                #endregion
                try
                {
                    if (PostIndustry != null)
                    {
                        PostIndustryReturnDTO = new PostIndustryReturnDTO
                        {
                            IndustryId = PostIndustry.IndustryId,
                            PostId = PostIndustry.PostId,
                            PostIndustryId = PostIndustry.PostIndustryId
                            
                        };
                    }
                }
                catch (Exception exception)
                { }
                return PostIndustryReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




