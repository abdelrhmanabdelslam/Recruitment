using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Recruitment.Common.RequestHandler
{
    public class HTTPResponseJsonDTO<T>
    {
        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.InternalServerError;
        public T Body { get; set; } = (T)Activator.CreateInstance(typeof(T));
    }
}
