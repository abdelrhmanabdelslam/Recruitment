using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyCoverImageDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyCoverImageMapping : IDisposable, ICompanyCoverImageMapping
    {
        public List<CompanyCoverImageReturnDTO> MappingCompanyCoverImageToCompanyCoverImageReturnDTO(List<CompanyCoverImage> CompanyCoverImageList)
        {

            List<CompanyCoverImageReturnDTO> CompanyCoverImageReturnDTOList = null;
            try
            {
                if (CompanyCoverImageList.Any() && CompanyCoverImageList != null)
                {
                    CompanyCoverImageReturnDTOList = CompanyCoverImageList.Select(u => new CompanyCoverImageReturnDTO
                    {
                        CompanyCoverImageId = u.ComapnyCoverImageId,
                        CompanyInformationId = u. CompanyInformationId,
                        ComapnyCoverImageURL = u.ComapnyCoverImageUrl,
                        IsMainCover = u.IsMainCover
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyCoverImageReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyCoverImage></returns>
        public CompanyCoverImage MappingCompanyCoverImageAddDTOToCompanyCoverImage(CompanyCoverImageAddDTO CompanyCoverImageAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyCoverImage CompanyCoverImage = null;
                #endregion
                try
                {
                    CompanyCoverImage = new CompanyCoverImage
                    {
                        CompanyInformationId = CompanyCoverImageAddDTO.CompanyInformationId,
                        ComapnyCoverImageUrl = CompanyCoverImageAddDTO.ComapnyCoverImageUrl,
                        IsMainCover = CompanyCoverImageAddDTO.IsMainCover,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyCoverImage;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyCoverImage MappingCompanyCoverImageupdateDTOToCompanyCoverImage(CompanyCoverImage companyCoverImage, CompanyCoverImageUpdateDTO CompanyCoverImageUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyCoverImage CompanyCoverImage = companyCoverImage;
                #endregion
                try
                {
                    if (CompanyCoverImageUpdateDTO.CompanyCoverImageId > default(int))
                    {
                        CompanyCoverImage.ComapnyCoverImageId = CompanyCoverImageUpdateDTO.CompanyCoverImageId;
                        CompanyCoverImage.CompanyInformationId = CompanyCoverImageUpdateDTO.CompanyInformationId;
                        CompanyCoverImage.ComapnyCoverImageUrl = CompanyCoverImageUpdateDTO.ComapnyCoverImageUrl;
                        CompanyCoverImage.IsMainCover = CompanyCoverImageUpdateDTO.IsMainCover;
                    }
                }
                catch (Exception exception) { }
                return CompanyCoverImage;
            }
            public CompanyCoverImageReturnDTO MappingCompanyCoverImageToCompanyCoverImageReturnDTO(CompanyCoverImage CompanyCoverImage)
            {
                #region Declare a return type with initial value.
                CompanyCoverImageReturnDTO CompanyCoverImageReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyCoverImage != null)
                    {
                        CompanyCoverImageReturnDTO = new CompanyCoverImageReturnDTO
                        {
                            CompanyCoverImageId = CompanyCoverImage.ComapnyCoverImageId,
                            CompanyInformationId = CompanyCoverImage.CompanyInformationId,
                            ComapnyCoverImageURL = CompanyCoverImage.ComapnyCoverImageUrl,
                            IsMainCover = CompanyCoverImage.IsMainCover,
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyCoverImageReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




