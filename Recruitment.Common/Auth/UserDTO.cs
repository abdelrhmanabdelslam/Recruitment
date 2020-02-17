using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPMATS.Common.Auth
{
    public class UserDTO : ICloneable
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        [IgnoreDataMember]
        public string UserPasswordHash { get; set; }
        [IgnoreDataMember]
        public string UserPasswordSalt { get; set; }
        public long RoleId { get; set; }
        public bool IsActive { get; set; }
        public string Token { get; set; }


        public object Clone()
        {
            return new UserDTO()
            {
                UserId = UserId,
                Email = Email,
                UserName = UserName,
                RoleId = RoleId,
                IsActive=IsActive,
                Token = Token,
            };
        }
    }
}
