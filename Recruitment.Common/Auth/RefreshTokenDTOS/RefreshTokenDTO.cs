﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IPMATS.Common.Auth
{
   public  class RefreshTokenDTO
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}
