using System;
namespace Recruitment.Common.Base
{
    public class BaseAppService : IDisposable
    {
        #region Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}