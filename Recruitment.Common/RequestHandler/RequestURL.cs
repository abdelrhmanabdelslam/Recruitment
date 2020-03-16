using IPMATS.Common.Helper;
using Newtonsoft.Json;
using Recruitment.Common.Enums;
using Recruitment.Common.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using static UUL.Logger.UUL.Core.UUL.Common.Enums.Enums;
namespace Recruitment.Common.RequestHandler
{
    public static class RequestURL
    {
        /// <summary>
        /// Request URL 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">Target url.</param>
        /// <param name="requestType">Target url.</param>
        /// <param name="obj">posted object.</param>
        /// <returns>HTTPResponseJsonDTO<T></returns>
        public static HTTPResponseJsonDTO<T> HTTPRequest<T>(string url, RequestType requestType, object obj = null)
        {
            #region Declare return type with initial value
            HTTPResponseJsonDTO<T> response = null;
            #endregion
            try
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    #region Create Request
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.Timeout = ConfigHelper.RequestTimeoutInMiliseconds;
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = requestType.ToString();
                    httpWebRequest.Accept = "application/json";
                    #endregion
                    #region Send Object
                    if (requestType == RequestType.POST && obj != null)
                    {
                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                        {
                            if (obj != null)
                                streamWriter.Write(JsonConvert.SerializeObject(obj));
                            streamWriter.Flush();
                            streamWriter.Close();
                        }
                    }
                    #endregion
                    #region Get Response
                    HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (httpResponse != null)
                    {
                        string content = string.Empty;
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            content = streamReader.ReadToEnd();
                        }
                        if (!string.IsNullOrWhiteSpace(content))
                        {
                            response = new HTTPResponseJsonDTO<T>()
                            {
                                HttpStatusCode = httpResponse.StatusCode,
                                Body = JsonConvert.DeserializeObject<T>(content)
                            };
                        }
                    }
                    #endregion 
                }
            }
            catch (WebException webex)
            {
                WebResponse errResp = webex.Response;
                HttpWebResponse resp = (HttpWebResponse)webex.Response;
                using (Stream respStream = errResp.GetResponseStream())
                {
                    if (resp.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = new StreamReader(respStream).ReadToEnd();
                        if (!string.IsNullOrWhiteSpace(content))
                        {
                            response = new HTTPResponseJsonDTO<T>()
                            {
                                HttpStatusCode = resp.StatusCode,
                                Body = JsonConvert.DeserializeObject<T>(content)
                            };
                        }
                        else
                        {
                            Logger.Instance.LogException(webex, LogLevel.Medium);


                        }
                    }
                    else
                    {
                        Logger.Instance.LogException(webex, LogLevel.Medium);
                    }
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogException(exception, LogLevel.Medium);
            }

            return response;
        }






    }
}
