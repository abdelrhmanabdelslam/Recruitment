using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostJobRoleDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class PostJobRoleMapping : IDisposable, IPostJobRoleMapping
    {
        public List<PostJobRoleReturnDTO> MappingPostJobRoleToPostJobRoleReturnDTO(List<PostJobRole> PostJobRoleList)
        {

            List<PostJobRoleReturnDTO> PostJobRoleReturnDTOList = null;
            try
            {
                if (PostJobRoleList.Any() && PostJobRoleList != null)
                {
                    PostJobRoleReturnDTOList = PostJobRoleList.Select(u => new PostJobRoleReturnDTO
                    {
                        JobRoleId = u.JobRoleId,
                        PostId = u.PostId,
                        PostJobRoleId = u.PostJobRoleId
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return PostJobRoleReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<PostJobRole></returns>
        public PostJobRole MappingPostJobRoleAddDTOToPostJobRole(PostJobRoleAddDTO PostJobRoleAddDTO)
            {
                #region Declare a return type with initial value.
                PostJobRole PostJobRole = null;
                #endregion
                try
                {
                    PostJobRole = new PostJobRole
                    {
                        JobRoleId = PostJobRoleAddDTO.JobRoleId,
                        PostId = PostJobRoleAddDTO.PostId,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return PostJobRole;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public PostJobRole MappingPostJobRoleupdateDTOToPostJobRole(PostJobRole postJobRole, PostJobRoleUpdateDTO PostJobRoleUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                PostJobRole PostJobRole = postJobRole;
                #endregion
                try
                {
                    if (PostJobRoleUpdateDTO.PostJobRoleId > default(int))
                    {

                        PostJobRole.JobRoleId = PostJobRoleUpdateDTO.JobRoleId;
                        PostJobRole.PostId = PostJobRoleUpdateDTO.PostId;
                        PostJobRole.PostJobRoleId = PostJobRoleUpdateDTO.PostJobRoleId;
                    }
                }
                catch (Exception exception) { }
                return PostJobRole;
            }
            public PostJobRoleReturnDTO MappingPostJobRoleToPostJobRoleReturnDTO(PostJobRole PostJobRole)
            {
                #region Declare a return type with initial value.
                PostJobRoleReturnDTO PostJobRoleReturnDTO = null;
                #endregion
                try
                {
                    if (PostJobRole != null)
                    {
                        PostJobRoleReturnDTO = new PostJobRoleReturnDTO
                        {

                            JobRoleId = PostJobRole.JobRoleId,
                            PostId = PostJobRole.PostId,
                            PostJobRoleId = PostJobRole.PostJobRoleId
                        };
                    }
                }
                catch (Exception exception)
                { }
                return PostJobRoleReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




