using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostTypeDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class PostTypeMapping : IDisposable, IPostTypeMapping
    {
        public List<PostTypeReturnDTO> MappingPostTypeToPostTypeReturnDTO(List<PostType> PostTypeList)
        {

            List<PostTypeReturnDTO> PostTypeReturnDTOList = null;
            try
            {
                if (PostTypeList.Any() && PostTypeList != null)
                {
                    PostTypeReturnDTOList = PostTypeList.Select(u => new PostTypeReturnDTO
                    {
                        PostTypeId = u.PostTypeId,
                        PostTypeName  = u.PostTypeName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return PostTypeReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<PostType></returns>
        public PostType MappingPostTypeAddDTOToPostType(PostTypeAddDTO PostTypeAddDTO)
            {
                #region Declare a return type with initial value.
                PostType PostType = null;
                #endregion
                try
                {
                    PostType = new PostType
                    {
                        PostTypeName = PostTypeAddDTO.PostTypeName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return PostType;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public PostType MappingPostTypeupdateDTOToPostType(PostType postType, PostTypeUpdateDTO PostTypeUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                PostType PostType = postType;
                #endregion
                try
                {
                    if (PostTypeUpdateDTO.PostTypeId > default(int))
                    {
                        PostType.PostTypeId = PostTypeUpdateDTO.PostTypeId;
                        PostType.PostTypeName = PostTypeUpdateDTO.PostTypeName;
                    }
                }
                catch (Exception exception) { }
                return PostType;
            }
            public PostTypeReturnDTO MappingPostTypeToPostTypeReturnDTO(PostType PostType)
            {
                #region Declare a return type with initial value.
                PostTypeReturnDTO PostTypeReturnDTO = null;
                #endregion
                try
                {
                    if (PostType != null)
                    {
                        PostTypeReturnDTO = new PostTypeReturnDTO
                        {
                            PostTypeId = PostType.PostTypeId,
                            PostTypeName = PostType.PostTypeName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return PostTypeReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




