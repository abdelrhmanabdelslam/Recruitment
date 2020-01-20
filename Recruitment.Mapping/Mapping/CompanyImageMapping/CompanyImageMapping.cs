using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyImageDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyImageMapping : IDisposable, ICompanyImageMapping
    {
        public List<CompanyImageReturnDTO> MappingCompanyImageToCompanyImageReturnDTO(List<CompanyImage> CompanyImageList)
        {

            List<CompanyImageReturnDTO> CompanyImageReturnDTOList = null;
            try
            {
                if (CompanyImageList.Any() && CompanyImageList != null)
                {
                    CompanyImageReturnDTOList = CompanyImageList.Select(u => new CompanyImageReturnDTO
                    {
                        CompanyInformationId = u.CompanyInformationId,
                        CompanyImgeURL = u.CompanyImgeUrl,
                        IsMainPhoto = u.IsMainPhoto,
                    }).ToList();
                }
            }
            catch (Exception exception)
            {

            }
            return CompanyImageReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyImage></returns>
        public CompanyImage MappingCompanyImageAddDTOToCompanyImage(CompanyImageAddDTO CompanyImageAddDTO)
        {
            #region Declare a return type with initial value.
            CompanyImage CompanyImage = null;
            #endregion
            try
            {
                CompanyImage = new CompanyImage
                {
                    CompanyInformationId = CompanyImageAddDTO.CompanyInformationId,
                    CompanyImgeUrl = CompanyImageAddDTO.CompanyImgeURL,
                    IsMainPhoto = CompanyImageAddDTO.IsMainPhoto,
                    CreationDate = DateTime.Now,
                    IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                };
            }
            catch (Exception exception) { }
            return CompanyImage;
        }
        /// <summary>
        /// Mapping User Activity Log DTO to Action
        /// </summary>
        /// <param name=></param>
        /// <param name=></param>
        /// <returns></returns>
        public CompanyImage MappingCompanyImageupdateDTOToCompanyImage(CompanyImage companyImage, CompanyImageUpdateDTO CompanyImageUpdateDTO)
        {
            #region Declare Return Var with Intial Value
            CompanyImage CompanyImage = companyImage;
            #endregion
            try
            {
                if (CompanyImageUpdateDTO.CompanyImageId > default(int))
                {
                    CompanyImage.CompanyImageId = CompanyImageUpdateDTO.CompanyImageId;
                    CompanyImage.CompanyInformationId = CompanyImageUpdateDTO.CompanyInformationId;
                    CompanyImage.CompanyImgeUrl = CompanyImageUpdateDTO.CompanyImgeURL;
                    CompanyImage.IsMainPhoto = CompanyImageUpdateDTO.IsMainPhoto;
                }
            }
            catch (Exception exception) { }
            return CompanyImage;
        }
        public CompanyImageReturnDTO MappingCompanyImageToCompanyImageReturnDTO(CompanyImage CompanyImage)
        {
            #region Declare a return type with initial value.
            CompanyImageReturnDTO CompanyImageReturnDTO = null;
            #endregion

            try
            {
                if (CompanyImage != null)
                {
                    CompanyImageReturnDTO = new CompanyImageReturnDTO
                    {
                        CompanyInformationId = CompanyImage.CompanyInformationId,
                        CompanyImgeURL = CompanyImage.CompanyImgeUrl,
                        IsMainPhoto = CompanyImage.IsMainPhoto
                    };
                }
            }
            catch (Exception exception)
            {
            }

            return CompanyImageReturnDTO;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}




