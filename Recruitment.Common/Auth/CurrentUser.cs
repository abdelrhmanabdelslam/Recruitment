using System;
using System.Collections.Generic;
using System.Text;

namespace IPMATS.Common.Auth
{

    public class CurrentUser : ICurrentUser
    {
        public int UserId { get; set; }
       public  string Email { get; set; }
    }
    public interface ICurrentUser
    {
        int UserId { get; set; }
        string Email { get; set; }
    }
}
