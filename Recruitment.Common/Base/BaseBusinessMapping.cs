using System;
namespace Recruitment.Common.Base
{
    public class BaseBusinessMapping : IDisposable
    {
        #region Methods
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
