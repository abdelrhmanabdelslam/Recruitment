using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.PostDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class PostMapping : IDisposable, IPostMapping
    {
        public List<PostReturnDTO> MappingPostToPostReturnDTO(List<Post> PostList)
        {

            List<PostReturnDTO> PostReturnDTOList = null;
            try
            {
                if (PostList.Any() && PostList != null)
                {
                    PostReturnDTOList = PostList.Select(u => new PostReturnDTO
                    {
                        PostId = u.PostId,
                        YearsOfExperience = u.YearsOfExperience,
                        AddationalSalary = u.AddationalSalary,
                        Area = u.Area,
                        CareerLevelId = u.CareerLevelId,
                        IsClosed = u.IsClosed,
                        IsHideSalary = u.IsHideSalary,
                        NumberOfVacancies = u.NumberOfVacancies,
                        PostDescription = u.PostDescription,
                        PostLocationId = u.PostLocationId,
                        PostTypeId = u.PostTypeId,
                        SalaryFrom = u.SalaryFrom,
                        SalaryTo = u.SalaryTo
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return PostReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Post></returns>
        public Post MappingPostAddDTOToPost(PostAddDTO PostAddDTO)
            {
                #region Declare a return type with initial value.
                Post Post = null;
                #endregion
                try
                {
                    Post = new Post
                    {
                        YearsOfExperience = PostAddDTO.YearsOfExperience,
                        AddationalSalary = PostAddDTO.AddationalSalary,
                        Area = PostAddDTO.Area,
                        CareerLevelId = PostAddDTO.CareerLevelId,
                        IsClosed = PostAddDTO.IsClosed,
                        IsHideSalary = PostAddDTO.IsHideSalary,
                        NumberOfVacancies = PostAddDTO.NumberOfVacancies,
                        PostDescription = PostAddDTO.PostDescription,
                        PostLocationId = PostAddDTO.PostLocationId,
                        PostTypeId = PostAddDTO.PostTypeId,
                        SalaryFrom = PostAddDTO.SalaryFrom,
                        SalaryTo = PostAddDTO.SalaryTo,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Post;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Post MappingPostupdateDTOToPost(Post post, PostUpdateDTO PostUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Post Post = post;
                #endregion
                try
                {
                    if (PostUpdateDTO.PostId > default(int))
                    {
                        Post.PostId = PostUpdateDTO.PostId;
                        Post.YearsOfExperience = PostUpdateDTO.YearsOfExperience;
                        Post.AddationalSalary = PostUpdateDTO.AddationalSalary;
                        Post.Area = PostUpdateDTO.Area;
                        Post.CareerLevelId = PostUpdateDTO.CareerLevelId;
                        Post.IsClosed = PostUpdateDTO.IsClosed;
                        Post.IsHideSalary = PostUpdateDTO.IsHideSalary;
                        Post.NumberOfVacancies = PostUpdateDTO.NumberOfVacancies;
                        Post.PostDescription = PostUpdateDTO.PostDescription;
                        Post.PostLocationId = PostUpdateDTO.PostLocationId;
                        Post.PostTypeId = PostUpdateDTO.PostTypeId;
                        Post.SalaryFrom = PostUpdateDTO.SalaryFrom;
                        Post.SalaryTo = PostUpdateDTO.SalaryTo;
                    }
                }
                catch (Exception exception) { }
                return Post;
            }
            public PostReturnDTO MappingPostToPostReturnDTO(Post Post)
            {
                #region Declare a return type with initial value.
                PostReturnDTO PostReturnDTO = null;
                #endregion
                try
                {
                    if (Post != null)
                    {
                        PostReturnDTO = new PostReturnDTO
                        {
                           PostId = Post.PostId,
                           YearsOfExperience = Post.YearsOfExperience,
                           AddationalSalary = Post.AddationalSalary,
                           Area = Post.Area,
                           CareerLevelId = Post.CareerLevelId,
                           IsClosed = Post.IsClosed,
                           IsHideSalary = Post.IsHideSalary,
                           NumberOfVacancies = Post.NumberOfVacancies,
                           PostDescription = Post.PostDescription,
                           PostLocationId = Post.PostLocationId,
                           PostTypeId = Post.PostTypeId,
                           SalaryFrom = Post.SalaryFrom,
                           SalaryTo = Post.SalaryTo
                        };
                    }
                }
                catch (Exception exception)
                { }
                return PostReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




