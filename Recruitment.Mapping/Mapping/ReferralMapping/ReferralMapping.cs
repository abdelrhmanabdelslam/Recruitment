using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using Recruitment.DTOS.ReferralDTOS;
using Recruitment.Mapping.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Entity.Models;

namespace Recruitment.Mapping.Mapping
{
    public class ReferralMapping : IDisposable, IReferralMapping
    {
        public List<ReferralReturnDTO> MappingReferralToReferralReturnDTO(List<Referral> ReferralList)
        {

            List<ReferralReturnDTO> ReferralReturnDTOList = null;
            try
            {
                if (ReferralList.Any() && ReferralList != null)
                {
                    ReferralReturnDTOList = ReferralList.Select(u => new ReferralReturnDTO
                    {
                        ReferralId = u.ReferralId,
                        ReferralName  = u.ReferralName 
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                
            }
            return ReferralReturnDTOList;
        }
        /// <summary>
        /// Mapping user Action Actitvity Log
        /// </summary>
        /// <param name=></ param >
        /// <returns>Task<Referral></returns>
        public Referral MappingReferralAddDTOToReferral(ReferralAddDTO ReferralAddDTO)
            {
                #region Declare a return type with initial value.
                Referral Referral = null;
                #endregion
                try
                {
                    Referral = new Referral
                    {
                        ReferralName = ReferralAddDTO.ReferralName,
                        CreationDate = DateTime.Now,
                        IsDeleted = (byte)DeleteStatusEnum.NotDeleted
                    };
                }
                catch (Exception exception) { }
                return Referral;
            }
            /// <summary>
            /// Mapping User Activity Log DTO to Action
            /// </summary>
            /// <param name=></param>
            /// <param name=></param>
            /// <returns></returns>
            public Referral MappingReferralupdateDTOToReferral(Referral referral, ReferralUpdateDTO ReferralUpdateDTO)
            {
                #region Declare Return Var with Intial Value
                Referral Referral = referral;
                #endregion
                try
                {
                    if (ReferralUpdateDTO.ReferralId > default(int))
                    {
                        Referral.ReferralId = ReferralUpdateDTO.ReferralId;
                        Referral.ReferralName = ReferralUpdateDTO.ReferralName;
                    }
                }
                catch (Exception exception) { }
                return Referral;
            }
            public ReferralReturnDTO MappingReferralToReferralReturnDTO(Referral Referral)
            {
                #region Declare a return type with initial value.
                ReferralReturnDTO ReferralReturnDTO = null;
                #endregion
                try
                {
                    if (Referral != null)
                    {
                        ReferralReturnDTO = new ReferralReturnDTO
                        {
                            ReferralId = Referral.ReferralId,
                            ReferralName = Referral.ReferralName
                        };
                    }
                }
                catch (Exception exception)
                { }
                return ReferralReturnDTO;
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }




