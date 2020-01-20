using Recruitment.Common.Base;
using Recruitment.Common.Helper;
using Recruitment.DataService.BusinessMapping;
using Recruitment.DTOS.IndustryDTOS;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Business.AppService
{
    public class IndustryAppService : BaseAppService, IIndustryAppService
    {
        #region Properties
        public IIndustryBusinessMapping IndustryBusinessMapping { get; }
        #endregion

        #region Constructor
        public IndustryAppService(IIndustryBusinessMapping industryBusinessMapping)
        {
            IndustryBusinessMapping = industryBusinessMapping;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Get All Industry ActionActivity Logs for All Industrys
        /// </summary>
        /// <returns>List<IndustryReturnDTO></returns>
        public async Task<List<IndustryReturnDTO>> GetAllIndustrys()
        {
            #region Declare a return type with initial value.
            List<IndustryReturnDTO> allIndustrys = null;
            #endregion
            try
            {
                allIndustrys = await IndustryBusinessMapping.GetAllIndustrys();
            }
            catch (Exception exception)  {}
            return allIndustrys;
        }
        /// <summary>
        /// Add Industry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> AddIndustry(GradeAddDTO industryAddDTO)
        {
            #region Declare a return type with initial value.
            bool isCreated = false;
            #endregion
            try
            {
                if (industryAddDTO != null)
                {
                    isCreated = await IndustryBusinessMapping.AddIndustry(industryAddDTO);
                }
            }
            catch (Exception exception){}
            return isCreated;
        }
        /// <summary>
        /// Get  Industry By Id 
        /// </summary>
        /// <returns>IndustryReturnDTO<IndustryReturnDTO></returns>
        public async Task<IndustryReturnDTO> GetIndustryById(int IndustryId)
        {
            #region Declare a return type with initial value.
            IndustryReturnDTO Industry = null;
            #endregion
            try
            {
                if (IndustryId > default(int))
                {
                    Industry = await IndustryBusinessMapping.GetIndustryById(IndustryId);
                }
            }
            catch (Exception exception)  {}
            return Industry;
        }
        /// <summary>
        /// Updae Industry AppService
        /// </summary>
        /// <returns>bool<bool></returns>
        public async Task<bool> UpdateIndustry(GradeUpdateDTO industryUpdateDTO)
        {
            #region Declare a return type with initial value.
            bool isUpdated = false;
            #endregion
            try
            {
                if (industryUpdateDTO != null)
                {
                    isUpdated = await IndustryBusinessMapping.UpdateIndustry(industryUpdateDTO);
                }
            }
            catch (Exception exception){}
            return isUpdated;
        }
        /// <summary>
        /// Delete Industry AppService
        /// </summary>
        /// <returns>Boolean></returns>
        public async Task<bool> DeleteIndustry(int IndustryId)
        {
            bool isDeleted = false;
            try
            {
                if (IndustryId > default(int))
                {
                    isDeleted = await IndustryBusinessMapping.DeleteIndustry(IndustryId);
                }
            }
            catch (Exception exception) { }
            return isDeleted;
        }
        #endregion
    }
}


