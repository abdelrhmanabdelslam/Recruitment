using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyCoverImageDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyCoverImageBusinessMapping : BaseBusinessMapping, ICompanyCoverImageBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyCoverImageMapping CompanyCoverImageMapping { get; }
        #endregion

        #region Constructor
        public CompanyCoverImageBusinessMapping(IUnitOfWork unitOfWork, ICompanyCoverImageMapping companyCoverImageMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyCoverImageMapping = companyCoverImageMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyCoverImageReturnDTO></returns>
        public async Task<List<CompanyCoverImageReturnDTO>> GetAllCompanyCoverImages()
        {
            #region Declare Return Var with Intial Value
            List<CompanyCoverImageReturnDTO> allCompanyCoverImages = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyCoverImage> CompanyCoverImageList = null;
                #endregion
                CompanyCoverImageList = await UnitOfWork.CompanyCoverImageRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyCoverImageList != null && CompanyCoverImageList.Any())
                {
                    allCompanyCoverImages = CompanyCoverImageMapping.MappingCompanyCoverImageToCompanyCoverImageReturnDTO(CompanyCoverImageList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyCoverImages;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyCoverImage(CompanyCoverImageAddDTO CompanyCoverImageAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyCoverImageCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyCoverImage CompanyCoverImage = null;
                    #endregion
                    CompanyCoverImage = CompanyCoverImageMapping.MappingCompanyCoverImageAddDTOToCompanyCoverImage(CompanyCoverImageAddDTO);
                    if (CompanyCoverImage != null)
                    {
                        await UnitOfWork.CompanyCoverImageRepository.Insert(CompanyCoverImage);
                        isCompanyCoverImageCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyCoverImageCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyCoverImageReturnDTO></returns>
            public async Task<CompanyCoverImageReturnDTO> GetCompanyCoverImageById(int CompanyCoverImageId)
            {
                #region Declare a return type with initial value.
                CompanyCoverImageReturnDTO CompanyCoverImage = new CompanyCoverImageReturnDTO();
                #endregion
                try
                {
                    CompanyCoverImage companyCoverImage = await UnitOfWork.CompanyCoverImageRepository.GetById(CompanyCoverImageId);
                    if (companyCoverImage != null)
                    {
                        if (companyCoverImage.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyCoverImage = CompanyCoverImageMapping.MappingCompanyCoverImageToCompanyCoverImageReturnDTO(companyCoverImage);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyCoverImage;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyCoverImage(CompanyCoverImageUpdateDTO CompanyCoverImageUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyCoverImageUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyCoverImageUpdateDTO != null)
                    {
                        #region Vars
                        CompanyCoverImage CompanyCoverImage = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyCoverImage = await UnitOfWork.CompanyCoverImageRepository.GetById(CompanyCoverImageUpdateDTO.CompanyCoverImageId);
                        #endregion
                        if (CompanyCoverImage != null)
                        {
                            #region  Mapping
                            CompanyCoverImage = CompanyCoverImageMapping.MappingCompanyCoverImageupdateDTOToCompanyCoverImage(CompanyCoverImage ,CompanyCoverImageUpdateDTO);
                            #endregion
                            if (CompanyCoverImage != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyCoverImageRepository.Update(CompanyCoverImage);
                                isCompanyCoverImageUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyCoverImageUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyCoverImage(int CompanyCoverImageId)
            {
                #region Declare a return type with initial value.
                bool isCompanyCoverImageDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyCoverImageId > default(int))
                    {
                        #region Vars
                        CompanyCoverImage CompanyCoverImage = null;
                        #endregion
                        #region Get CompanyCoverImage by id
                        CompanyCoverImage = await UnitOfWork.CompanyCoverImageRepository.GetById(CompanyCoverImageId);
                        #endregion
                        #region check if object is not null
                        if (CompanyCoverImage != null)
                        {
                            CompanyCoverImage.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyCoverImageRepository.Update(CompanyCoverImage);
                            isCompanyCoverImageDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyCoverImageDeleted;
            }
#endregion
        }
    }




