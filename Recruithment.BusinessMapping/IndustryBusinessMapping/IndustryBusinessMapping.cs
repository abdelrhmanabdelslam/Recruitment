using Microsoft.EntityFrameworkCore;
using Recruitment.Common.Base;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.IndustryDTOS;
using Recruitment.EntitiesService.UnitOfWork;
using Recruitment.Entity.Models;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.DataService.BusinessMapping
{
    public class IndustryBusinessMapping : BaseBusinessMapping, IIndustryBusinessMapping
    {
        #region Properties
        private IUnitOfWork UnitOfWork { get; }
        public IIndustryMapping IndustryMapping { get; }
        #endregion

        #region Constructor
        public IndustryBusinessMapping(IUnitOfWork unitOfWork, IIndustryMapping industryMapping)
        {
            UnitOfWork = unitOfWork;
            IndustryMapping = industryMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All User Action Activity Logs
        /// </summary>
        /// <returns>List<IndustryReturnDTO></returns>
        public async Task<List<IndustryReturnDTO>> GetAllIndustrys()
        {
            #region Declare Return Var with Intial Value
            List<IndustryReturnDTO> allIndustrys = null;
            #endregion
            try
            {
                #region Vars
                List<Industry> IndustryList = null;
                #endregion
                IndustryList = await UnitOfWork.IndustryRepository.GetWhere(f => f.IsDeleted != (byte)DeleteStatusEnum.Deleted).ToListAsync();
                if (IndustryList != null && IndustryList.Any())
                {
                    allIndustrys = IndustryMapping.MappingIndustryToIndustryReturnDTO(IndustryList);
                }
            }
            catch (Exception exception)
            {
                 
            }
            return allIndustrys;
        }
        /// <summary>
        /// Create User Action Activity Log
        /// </summary>
        /// <param name="></param>
        /// <returns>bool</returns>
        public async Task<bool> AddIndustry(GradeAddDTO IndustryAddDTO)
            {
                #region Declare a return type with initial value.
                bool isIndustryCreated = default(bool);
                #endregion
                try
                {
                    #region Vars
                    Industry Industry = null;
                    #endregion
                    Industry = IndustryMapping.MappingIndustryAddDTOToIndustry(IndustryAddDTO);
                    if (Industry != null)
                    {
                        await UnitOfWork.IndustryRepository.Insert(Industry);
                        isIndustryCreated = await UnitOfWork.Commit() > default(int);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isIndustryCreated;
            }
            /// <summary>
            /// Get user Action Activity Log By Id
            /// </summary>
            /// <returns>List<IndustryReturnDTO></returns>
            public async Task<IndustryReturnDTO> GetIndustryById(int IndustryId)
            {
                #region Declare a return type with initial value.
                IndustryReturnDTO Industry = new IndustryReturnDTO();
                #endregion
                try
                {
                    Industry industry = await UnitOfWork.IndustryRepository.GetById(IndustryId);
                    if (industry != null)
                    {
                        if (industry.IsDeleted  != (byte)DeleteStatusEnum.Deleted)
                            Industry = IndustryMapping.MappingIndustryToIndustryReturnDTO(industry);
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return Industry;
            }
            /// <summary>
            /// Update User Action Activity Log 
            /// </summary>
            /// <param name="></param>
            /// <returns>bool</returns>
            public async Task<bool> UpdateIndustry(GradeUpdateDTO IndustryUpdateDTO)
            {
                #region Declare a return type with initial value.
                bool isIndustryUpdated = default(bool);
                #endregion
                try
                {
                    if (IndustryUpdateDTO != null)
                    {
                        #region Vars
                        Industry Industry = null;
                        #endregion
                        #region Get Activity By Id
                        Industry = await UnitOfWork.IndustryRepository.GetById(1);
                        #endregion
                        if (Industry != null)
                        {
                            #region  Mapping
                            Industry = IndustryMapping.MappingIndustryupdateDTOToIndustry(Industry ,IndustryUpdateDTO);
                            #endregion
                            if (Industry != null)
                            {
                                #region  Update Entity
                                UnitOfWork.IndustryRepository.Update(Industry);
                                isIndustryUpdated = await UnitOfWork.Commit() > default(int);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isIndustryUpdated;
            }
            /// <summary>
            /// Delete User Action Activity Log
            /// </summary>
            /// <param name="></param>
            /// <returns>bool</returns>
            public async Task<bool> DeleteIndustry(int IndustryId)
            {
                #region Declare a return type with initial value.
                bool isIndustryDeleted = default(bool);
                #endregion
                try
                {
                    if (IndustryId > default(int))
                    {
                        #region Vars
                        Industry Industry = null;
                        #endregion
                        #region Get Industry by id
                        Industry = await UnitOfWork.IndustryRepository.GetById(IndustryId);
                        #endregion
                        #region check if object is not null
                        if (Industry != null)
                        {
                            Industry.IsDeleted = (byte)DeleteStatusEnum.Deleted;
                            #region Apply the changes to the database
                            UnitOfWork.IndustryRepository.Update(Industry);
                            isIndustryDeleted = await UnitOfWork.Commit() > default(int);
                            #endregion
                        }
                        #endregion
                    }
                }
                catch (Exception exception)
                {
                     
                }
                return isIndustryDeleted;
            }
#endregion
        }
    }


