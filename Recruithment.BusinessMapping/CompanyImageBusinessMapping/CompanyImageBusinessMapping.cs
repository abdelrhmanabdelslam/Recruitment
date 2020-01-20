using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyImageDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class CompanyImageBusinessMapping : BaseBusinessMapping, ICompanyImageBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public ICompanyImageMapping CompanyImageMapping { get; }
        #endregion

        #region Constructor
        public CompanyImageBusinessMapping(IUnitOfWork unitOfWork, ICompanyImageMapping companyImageMapping)
        {
            UnitOfWork = unitOfWork;
            CompanyImageMapping = companyImageMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<CompanyImageReturnDTO></returns>
        public async Task<List<CompanyImageReturnDTO>> GetAllCompanyImages()
        {
            #region Declare Return Var with Intial Value
            List<CompanyImageReturnDTO> allCompanyImages = null;
            #endregion
            try
            {
                #region Vars
                List<CompanyImage> CompanyImageList = null;
                #endregion
                CompanyImageList = await UnitOfWork.CompanyImageRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (CompanyImageList != null && CompanyImageList.Any())
                {
                    allCompanyImages = CompanyImageMapping.MappingCompanyImageToCompanyImageReturnDTO(CompanyImageList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allCompanyImages;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name=></param>
        /// <returns>bool</returns>
        public async Task<bool> AddCompanyImage(CompanyImageAddDTO CompanyImageAddDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyImageCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    CompanyImage CompanyImage = null;
                    #endregion
                    CompanyImage = CompanyImageMapping.MappingCompanyImageAddDTOToCompanyImage(CompanyImageAddDTO);
                    if (CompanyImage != null)
                    {
                        await UnitOfWork.CompanyImageRepository.Insert(CompanyImage);
                        isCompanyImageCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyImageCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<CompanyImageReturnDTO></returns>
            public async Task<CompanyImageReturnDTO> GetCompanyImageById(int CompanyImageId)
            {
                #region Declare a return type with initial value.
                CompanyImageReturnDTO CompanyImage = new CompanyImageReturnDTO();
                #endregion
                try
                {
                    CompanyImage companyImage = await UnitOfWork.CompanyImageRepository.GetById(CompanyImageId);
                    if (companyImage != null)
                    {
                        if (companyImage.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            CompanyImage = CompanyImageMapping.MappingCompanyImageToCompanyImageReturnDTO(companyImage);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return CompanyImage;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateCompanyImage(CompanyImageUpdateDTO CompanyImageUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isCompanyImageUpdated = default(bool);
                #endregion
                try
                {
                    if (CompanyImageUpdateDTO != null)
                    {
                        #region Vars
                        CompanyImage CompanyImage = null;
                        #endregion
                        #region Get Activity By Id
                        CompanyImage = await UnitOfWork.CompanyImageRepository.GetById(CompanyImageUpdateDTO.CompanyImageId);
                        #endregion
                        if (CompanyImage != null)
                        {
                            #region  Mapping
                            CompanyImage = CompanyImageMapping.MappingCompanyImageupdateDTOToCompanyImage(CompanyImage ,CompanyImageUpdateDTO);
                            #endregion
                            if (CompanyImage != null)
                            {
                                #region  Update Entity
                                UnitOfWork.CompanyImageRepository.Update(CompanyImage);
                                isCompanyImageUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyImageUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name=></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteCompanyImage(int CompanyImageId)
            {
                #region Declare a return type with initial value.
                bool isCompanyImageDeleted = default(bool);
                #endregion
                try
                {
                    if (CompanyImageId > default(int))
                    {
                        #region Vars
                        CompanyImage CompanyImage = null;
                        #endregion
                        #region Get CompanyImage by id
                        CompanyImage = await UnitOfWork.CompanyImageRepository.GetById(CompanyImageId);
                        #endregion
                        #region check if object is not null
                        if (CompanyImage != null)
                        {
                            CompanyImage.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.CompanyImageRepository.Update(CompanyImage);
                            isCompanyImageDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isCompanyImageDeleted;
            }
#endregion
        }
    }




