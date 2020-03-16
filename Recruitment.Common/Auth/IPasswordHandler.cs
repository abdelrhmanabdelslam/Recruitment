using System;
using System.Collections.Generic;
using System.Text;

namespace IPMATS.Common.Auth
{
    public interface IPasswordHandler
    {
        string CreatePasswordHash(string pwd);
        bool Validate(string password, string passwordHash);
        int GenerateRandomNumber();
    }
}
