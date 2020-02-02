using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostRelatedIndustryDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class PostRelatedIndustryMapping : IDisposable, IPostRelatedIndustryMapping
    {
        public List<PostRelatedIndustryReturnDTO> MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(List<PostRelatedIndustry> PostRelatedIndustryList)
        {

            List<PostRelatedIndustryReturnDTO> PostRelatedIndustryReturnDTOList = null;
            try
            {
                if (PostRelatedIndustryList.Any() && PostRelatedIndustryList != null)
                {
                    PostRelatedIndustryReturnDTOList = PostRelatedIndustryList.Select(u => new PostRelatedIndustryReturnDTO
                    {
                        IndustryId = u.IndustryId,
                        PostId = u.PostId,
                        PostRelatedIndustryId = u.PostRelatedIndustryId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return PostRelatedIndustryReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<PostRelatedIndustry></returns>
        public PostRelatedIndustry MappingPostRelatedIndustryAddDTOToPostRelatedIndustry(PostRelatedIndustryAddDTO PostRelatedIndustryAddDTO)
            {
                #region Declare a return type with initial value.
                PostRelatedIndustry PostRelatedIndustry = null;
                #endregion
                try
                {
                    PostRelatedIndustry = new PostRelatedIndustry
                    {
                        IndustryId = PostRelatedIndustryAddDTO.IndustryId,
                        PostId = PostRelatedIndustryAddDTO.PostId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return PostRelatedIndustry;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public PostRelatedIndustry MappingPostRelatedIndustryupdateDTOToPostRelatedIndustry(PostRelatedIndustry postRelatedIndustry, PostRelatedIndustryUpdateDTO PostRelatedIndustryUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                PostRelatedIndustry PostRelatedIndustry = postRelatedIndustry;
                #endregion
                try
                {
                    if (PostRelatedIndustryUpdateDTO.PostRelatedIndustryId > default(int))
                    {
                        PostRelatedIndustry.IndustryId = PostRelatedIndustryUpdateDTO.IndustryId;
                        PostRelatedIndustry.PostId = PostRelatedIndustryUpdateDTO.PostId;
                        PostRelatedIndustry.PostRelatedIndustryId = PostRelatedIndustryUpdateDTO.PostRelatedIndustryId;
                    }
                }
                catch (Exception exception) { }
                return PostRelatedIndustry;
            }
            public PostRelatedIndustryReturnDTO MappingPostRelatedIndustryToPostRelatedIndustryReturnDTO(PostRelatedIndustry PostRelatedIndustry)
            {
                #region Declare a return type with initial value.
                PostRelatedIndustryReturnDTO PostRelatedIndustryReturnDTO = null;
                #endregion
                try
                {
                    if (PostRelatedIndustry != null)
                    {
                        PostRelatedIndustryReturnDTO = new PostRelatedIndustryReturnDTO
                        {
                            IndustryId = PostRelatedIndustry.IndustryId,
                            PostId = PostRelatedIndustry.PostId,
                            PostRelatedIndustryId = PostRelatedIndustry.PostRelatedIndustryId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return PostRelatedIndustryReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




