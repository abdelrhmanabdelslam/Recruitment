using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.CompanyOnlinePresenceDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class CompanyOnlinePresenceMapping : IDisposable, ICompanyOnlinePresenceMapping
    {
        public List<CompanyOnlinePresenceReturnDTO> MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(List<CompanyOnlinePresence> CompanyOnlinePresenceList)
        {

            List<CompanyOnlinePresenceReturnDTO> CompanyOnlinePresenceReturnDTOList = null;
            try
            {
                if (CompanyOnlinePresenceList.Any() && CompanyOnlinePresenceList != null)
                {
                    CompanyOnlinePresenceReturnDTOList = CompanyOnlinePresenceList.Select(u => new CompanyOnlinePresenceReturnDTO
                    {
                        CompanyOnlinePresenceId = u.CompanyOnlinePresenceId,
                        CompanyInformationId = (int)u.CompanyInformationId,
                        Blog = u.Blog,
                        Facebook = u.Facebook,
                        LinkedIn = u.LinkedIn,
                        Twitter = u.Twitter
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return CompanyOnlinePresenceReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<CompanyOnlinePresence></returns>
        public CompanyOnlinePresence MappingCompanyOnlinePresenceAddDTOToCompanyOnlinePresence(CompanyOnlinePresenceAddDTO CompanyOnlinePresenceAddDTO)
            {
                #region Declare a return type with initial value.
                CompanyOnlinePresence CompanyOnlinePresence = null;
                #endregion
                try
                {
                    CompanyOnlinePresence = new CompanyOnlinePresence
                    {
                        CompanyInformationId = (int)CompanyOnlinePresenceAddDTO.CompanyInformationId,
                        Blog = CompanyOnlinePresenceAddDTO.Blog,
                        Facebook = CompanyOnlinePresenceAddDTO.Facebook,
                        LinkedIn = CompanyOnlinePresenceAddDTO.LinkedIn,
                        Twitter = CompanyOnlinePresenceAddDTO.Twitter,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return CompanyOnlinePresence;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public CompanyOnlinePresence MappingCompanyOnlinePresenceupdateDTOToCompanyOnlinePresence(CompanyOnlinePresence companyOnlinePresence, CompanyOnlinePresenceUpdateDTO CompanyOnlinePresenceUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                CompanyOnlinePresence CompanyOnlinePresence = companyOnlinePresence;
                #endregion
                try
                {
                    if (CompanyOnlinePresenceUpdateDTO.CompanyOnlinePresenceId > default(int))
                    {
                        CompanyOnlinePresence.CompanyOnlinePresenceId = CompanyOnlinePresenceUpdateDTO.CompanyOnlinePresenceId;
                        CompanyOnlinePresence.CompanyInformationId = (int)CompanyOnlinePresenceUpdateDTO.CompanyInformationId;
                        CompanyOnlinePresence.Blog = CompanyOnlinePresenceUpdateDTO.Blog;
                        CompanyOnlinePresence.Facebook = CompanyOnlinePresenceUpdateDTO.Facebook;
                        CompanyOnlinePresence.LinkedIn = CompanyOnlinePresenceUpdateDTO.LinkedIn;
                        CompanyOnlinePresence.Twitter = CompanyOnlinePresenceUpdateDTO.Twitter;
                    }
                }
                catch (Exception exception) { }
                return CompanyOnlinePresence;
            }
            public CompanyOnlinePresenceReturnDTO MappingCompanyOnlinePresenceToCompanyOnlinePresenceReturnDTO(CompanyOnlinePresence CompanyOnlinePresence)
            {
                #region Declare a return type with initial value.
                CompanyOnlinePresenceReturnDTO CompanyOnlinePresenceReturnDTO = null;
                #endregion
                try
                {
                    if (CompanyOnlinePresence != null)
                    {
                        CompanyOnlinePresenceReturnDTO = new CompanyOnlinePresenceReturnDTO
                        {
                            CompanyOnlinePresenceId = CompanyOnlinePresence.CompanyOnlinePresenceId,
                            CompanyInformationId = (int)CompanyOnlinePresence.CompanyInformationId,
                            Blog = CompanyOnlinePresence.Blog,
                            Facebook = CompanyOnlinePresence.Facebook,
                            LinkedIn = CompanyOnlinePresence.LinkedIn,
                            Twitter = CompanyOnlinePresence.Twitter
                        };
                    }
                }
                catch (Exception exception)
                { }
                return CompanyOnlinePresenceReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




