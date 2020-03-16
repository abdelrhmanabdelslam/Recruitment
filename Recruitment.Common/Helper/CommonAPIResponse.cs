using Recruitment.Common.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Recruitment.Common.Helper
{
    //public class CommonAPIResponse<T>
    //{
    //    #region Properties
    //    public string Message { get; set; } = string.Empty;
    //    public T InnerData { get; set; } = (T)Activator.CreateInstance(typeof(T));
    //    #endregion
    //}

    public class CommonAPIResponse<T>
    {
        #region Properties
        public string Message { get; set; } = string.Empty;
        public T InnerData { get; set; } = (T)Activator.CreateInstance(typeof(T));
        public APIResponseMessage APIResponseCode { get; set; }
        #endregion
    }
    //public class CommonBusinessDTO<T>
    //{
    //    #region Properties
    //    public APIResponseMessage Message { get; set; }
    //    public T InnerData { get; set; } = (T)Activator.CreateInstance(typeof(T));
    //    public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.InternalServerError;
    //    #endregion
    //}
    public class CommonBusinessDTO<T>
    {
        #region Properties
        public APIResponseMessage Message { get; set; }
        public T InnerData { get; set; } = (T)Activator.CreateInstance(typeof(T));
        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.InternalServerError;
        public APIResponseMessage APIResponseCode { get; set; } = APIResponseMessage.InternalServerError;
        #endregion
    }

    public class OdooAPIResponse
    {
        public string Message { get; set; } = string.Empty;
        public APIResponseMessage Key { get; set; } 
    }
      
}
